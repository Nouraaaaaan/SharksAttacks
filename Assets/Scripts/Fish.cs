using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    //------------------Events and Delegates---------------//
    public delegate void EnemyHit();
    public  event EnemyHit Hit;

    public delegate void TreasureCollect();
    public static event TreasureCollect Collect;


    //-----------------------Methods------------------------//
    private void Start()
    {
        Hit += GameManager.Instance.EnemyHitEventController;
        Collect += GameManager.Instance.TreasureCollectEventController;
    }

    public void Move()//Controls Our Fish Movement;
    {
        
    }

    public void HitEnemy()//Called When Our Fish Hit An Enemy.
    {
        //Debug.Log("Our Fish hit an enemy !!");
        Hit();
    }

    public void CollectTreasure()//Called When Our Fish Collect A Treasure.
    {
        //Debug.Log("Our Fish Collected A Treasure!!");
        Collect();
    }

    private void OnCollisionEnter2D(Collision2D collision)//Called When Our Fish Collides With Another Collider.
    {
        if(collision.gameObject.tag == "Enemy")
          HitEnemy();

        if(collision.gameObject.tag == "Treasure")
          CollectTreasure();
    }

}
