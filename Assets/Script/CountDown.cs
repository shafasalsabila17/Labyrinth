using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using DG.Tweening;

public class CountDown : MonoBehaviour
{
    [SerializeField] int duration;
    
    public UnityEvent OnCountFinished = new UnityEvent();
    public UnityEvent<int> OnCount = new UnityEvent<int>();
    bool isCounting;
    Sequence seq;

    public void StartCount()
    {
        Debug.Log("StartCount");
        if (isCounting == true)
            return;
        else
            isCounting = true;

        seq = DOTween.Sequence();

        OnCount.Invoke(duration);
        for (int i = duration -1; i >= 0 ; i--)
        {
            seq.Append(transform
                .DOMove(this.transform.position,1)
                .OnComplete(()=> OnCount.Invoke(i)));
        }
        seq.Append(transform
            .DOMove(this.transform.position,1))
            .SetUpdate(true)
            .OnComplete(()=> OnCountFinished.Invoke());
            
        OnCountFinished.Invoke();
    }
}
