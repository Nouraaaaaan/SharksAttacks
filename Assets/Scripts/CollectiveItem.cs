using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectiveItem : MonoBehaviour
{   
    void Start()// Start is called before the first frame update
    {
        Vector3 CurrentScale = gameObject.transform.localScale;
        Vector3 TargetScale  = new Vector3(1f, 1f, 1f);
        StartCoroutine(DoPopupAnimation(1.5f, CurrentScale, TargetScale));
    }
   
    IEnumerator DoPopupAnimation(float TotalTime,Vector3 CurrentScale,Vector3 TargetScale)//Called To Animate Collictive Item.
    {
        Debug.Log("Starting Animation!");
        float ElapsedTime = 0.0f;
        
        while (ElapsedTime < TotalTime)
        {
            ElapsedTime += Time.deltaTime;
            gameObject.transform.localScale = Vector3.Lerp(CurrentScale,TargetScale,(ElapsedTime / TotalTime));
            yield return null;
        }

        Debug.Log("Ending Animation!");
    }

}
