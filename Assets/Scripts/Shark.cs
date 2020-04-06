using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : MonoBehaviour
{
    public GameObject[] Points;

    bool move;

    int index;

    // Start is called before the first frame update
    void Start()
    {
        move = true;
        //StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            move = false;

            index = Random.Range(0, Points.Length);
        }

        if (Vector3.Distance(transform.position, Points[index].transform.position) >= 0.5f)
        {
            //Debug.Log("Move");
            Vector3 dirNormalized = (Points[index].transform.position - transform.position).normalized;
            transform.position = transform.position + dirNormalized * 5f * Time.deltaTime;
        }
        else
        {

            index = Random.Range(0, Points.Length);

        }

       
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(2f);

        int index = Random.Range(0,Points.Length);

        while (Vector3.Distance(transform.position, Points[0].transform.position) >= 0.5f)
        {
            Debug.Log("Move");
            Vector3 dirNormalized = (Points[0].transform.position - transform.position).normalized;
            transform.position = transform.position + dirNormalized * 5f * Time.deltaTime;
        }

    }
}
