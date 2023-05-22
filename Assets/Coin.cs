using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Coin : MonoBehaviour
{
    [SerializeField] int value;
    [SerializeField] Transform visual;

    public int Value { get => value; }

    private void Start()
    {
        Animated();
    }

    private void Animated()
    {
        var seq = DOTween.Sequence();

        seq.Append( t: visual.DOLocalRotate(new Vector3(visual.eulerAngles.x, 180, 0),  0.5f));
        seq.Append( t: visual.DOLocalRotate(new Vector3(visual.eulerAngles.x, 360, 0),0.5f));
        seq.SetLoops(-1);

    }
}
