using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour

{
    
    [SerializeField] TMP_Text timerText;

    private float timer;
    private bool isGameOver;

    public void UpdateTimer(int timer)
    {
        timerText.text = timer.ToString();
    }

    void Start()
    {
        timer = 0f;
        isGameOver = false;
        Debug.Log("Game dimulai!");
    }

    void Update()
    {
        timer += Time.deltaTime;

      
        if (timer >= 120f)
        {

            isGameOver = true;
        }

        if (isGameOver)
        {
            Debug.Log("Game over!");

        }
    }

    
}
