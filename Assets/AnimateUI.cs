using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class AnimateUI : MonoBehaviour
{
    public float spawnDelay;
    public bool fadeIn;

    private RectTransform rTransform;
    private Vector2 storedData;

    void Awake()
    {
        rTransform = GetComponent<RectTransform>();
        storedData = rTransform.sizeDelta;
    }

    private void OnEnable()
    {
        DOTween.ClearCachedTweens();
        CancelInvoke("Animate");

        if (fadeIn)
        {
            TextMeshProUGUI text = GetComponent<TextMeshProUGUI>();
            text.color = new Color(text.color.r, text.color.g, text.color.b, 0);
        }
        else
        {
            rTransform.sizeDelta = new Vector2(0, storedData.y);
        }
        if(!IsInvoking("Animate"))
            Invoke("Animate", spawnDelay);
    }

    public void Animate()
    {
        if (fadeIn)
        {
            GetComponent<TextMeshProUGUI>().DOFade(1, 0.8f);
        }
        else
        {
            rTransform.DOSizeDelta(storedData, 0.5f);
        }

    }
}
