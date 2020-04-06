using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAnimation : MonoBehaviour
{
    public float ScaleOffset;
    private void Start()
    {
        iTween.ScaleBy(gameObject, iTween.Hash("x",gameObject.transform.localScale.x + ScaleOffset, "y", gameObject.transform.localScale.x + ScaleOffset, "z", gameObject.transform.localScale.x + ScaleOffset, "time",1f, "looptype", iTween.LoopType.loop));
    }
}
