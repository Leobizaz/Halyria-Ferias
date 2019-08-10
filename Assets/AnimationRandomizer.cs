using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimationRandomizer : MonoBehaviour
{
    Sequence mySequence;
    public Vector3 startPos;
    public Vector3 endPos;

    // Start is called before the first frame update
    void Start()
    {
        mySequence = DOTween.Sequence();
        mySequence.Append(transform.DOMove(endPos, 3).SetEase(Ease.InOutSine));
        mySequence.Append(transform.DOMove(startPos, 3).SetEase(Ease.InOutSine));
        mySequence.SetLoops(-1,LoopType.Restart);
        mySequence.Pause();
        Invoke("StartAnimation", Random.Range(0.1f, 1f));
    }
    //0.567 | 0.062 | 0.917
    // Update is called once per frame
    void Update()
    {
    

    }
    void StartAnimation()
    {
        mySequence.Play();
    }

}
