using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 mouse = Input.mousePosition;
        //Debug.Log(mouse.x);


        if (Input.GetAxis("Mouse X") == -1)
        {
            Debug.Log("negative");
        }
        if (Input.GetAxis("Mouse X") == 1)
        {
            Debug.Log("positive");
        }

    }



}
