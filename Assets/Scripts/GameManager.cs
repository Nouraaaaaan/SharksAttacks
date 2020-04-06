using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //-----------------------------------------Fields-------------------------------------------//
    [Header("Collective Items Settings")]
    public GameObject[] CollectiveItems;
    public GameObject[] CollectiveItemsPostions;
    public float CollectiveItemsRate;
    private float Timer;
    private GameObject CurrentCollectiveItem;

    [Header("Fish Life Settings")]
    public GameObject[] Hearts;
    private int RemainingHearts = 3;

    private static GameManager _instance; //Singelton Instance

    //-----------------------------------------Properties----------------------------------------//
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<GameManager>();
            }

            return _instance;
        }
    }

    //-----------------------------------------Methods-------------------------------------------//
    private void Start()
    {
        StartCoroutine(CollectiveItemController());
    }

    IEnumerator CollectiveItemController()
    {
        while (true)
        {
            Timer = CollectiveItemsRate;
            
            this.CurrentCollectiveItem = CollectiveItems[Random.Range(0, CollectiveItems.Length)];
            this.CurrentCollectiveItem.transform.position = CollectiveItemsPostions[Random.Range(0, CollectiveItemsPostions.Length)].transform.position;
            this.CurrentCollectiveItem.SetActive(true);
            

            while(Timer >= 0)
            {
                Timer -= Time.deltaTime;
                yield return null;
            }

            this.CurrentCollectiveItem.SetActive(false);

            yield return null;
        }
    }

    public void EnemyHitEventController()//Called When Our Fish Hit An Enemy.
    {
        Debug.Log("Our Fish hit an enemy !!");

        if(0 <= RemainingHearts - 1)
           Hearts[RemainingHearts - 1].gameObject.SetActive(false);

        RemainingHearts--;
    }

    public void TreasureCollectEventController()//Called When Our Fish Collect A Treasure.
    {
        Debug.Log("Our Fish Collected A Treasure!!");
        CurrentCollectiveItem.SetActive(false);
    }
}
