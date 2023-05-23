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

    [SerializeField] bool test = false;

    Coroutine countCoroutine;

    public void StartCount()
    {
        if (countCoroutine != null)
            return;
        countCoroutine =  StartCoroutine(CountCoroutine());
    }

    private IEnumerator CountCoroutine()
    {
        for (int i = duration; i >= 0; i--)
        {
            OnCount.Invoke(1);
            yield return new WaitForSecondsRealtime(1);
        }
        OnCountFinished.Invoke();
    }

    //public void StartCount()
    //{
    //    if (isCounting == true)
    //        return;
    //    else
    //        isCounting = true;
//
    //    Debug.Log(DOTween.Kill(seq));
//
    //    seq = DOTween.Sequence();
//
    //    OnCount.Invoke(duration);
    //    for (int i = duration -1; i >= 0 ; i--)
    //    {
    //        seq.Append(transform
    //            .DOMove(this.transform.position,1)
    //            .OnComplete(()=> OnCount.Invoke(i)));
    //    }
    //    seq.Append(transform
    //        .DOMove(this.transform.position,1))
    //        .SetUpdate(true)
    //        .OnComplete(()=> 
    //        {
    //            isCounting =  false;
    //            OnCountFinished.Invoke();
    //        }
    //        );
    //}
}
