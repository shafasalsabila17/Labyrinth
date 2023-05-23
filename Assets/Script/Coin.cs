using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Coin : MonoBehaviour
{
    [SerializeField] Transform visual;
    [SerializeField] CoinData coinData;
    [SerializeField] BaseAnimation baseAnimation;
    [SerializeField, Range(0,10)] float rotationSpeed = 2;

    public int Value { get => coinData.value; }

    private void Start()
    {
        visual.GetComponent<Renderer>().material = coinData.material;
        if (baseAnimation != null)
        baseAnimation.Animate(visual);
    }

    private void SelfDestruct()
    {
        Destroy(this.gameObject);
    }
    void Update()
    {
        transform.Rotate(0, 360*rotationSpeed*Time.deltaTime, 0);
    }

    
}
