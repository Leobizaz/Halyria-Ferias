using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class InfoPannel : MonoBehaviour
{
    void OnEnable()
    {
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 1200);
        gameObject.GetComponent<RectTransform>().DOSizeDelta((new Vector2(600, 1200)), 1.3f);
    }

    void Update()
    {
        
    }
}
