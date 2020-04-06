using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //-----------------------------------------Fields-------------------------------------------//
    bool wasJustClicked = true;
    bool canMove;
    Vector2 playerSize;

    //-----------------------------------------Methods-------------------------------------------//
    void Start()// Use this for initialization
    {
        playerSize = gameObject.GetComponent<SpriteRenderer>().bounds.extents;
    }
  
    void Update()// Update is called once per frame
    {

        if (Input.GetAxis("Mouse X") == -1)
        {
            //Debug.Log("negative");
            transform.rotation = new Quaternion(0,0,0,0);
        }
        if (Input.GetAxis("Mouse X") == 1)
        {
            Debug.Log("positive");
            transform.rotation = new Quaternion(0, 180, 0, 0);
        }

        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (wasJustClicked)
            {
                wasJustClicked = false;

                if ((mousePos.x >= transform.position.x && mousePos.x < transform.position.x + playerSize.x ||
                mousePos.x <= transform.position.x && mousePos.x > transform.position.x - playerSize.x) &&
                (mousePos.y >= transform.position.y && mousePos.y < transform.position.y + playerSize.y ||
                mousePos.y <= transform.position.y && mousePos.y > transform.position.y - playerSize.y))
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }
            }

            if (canMove)
            {
                transform.position = mousePos;
            }
        }
        else
        {
            wasJustClicked = true;
        }
    }
}