using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchTest : MonoBehaviour
{
    [SerializeField] GameObject visualTemplate;

    List<GameObject> visualList = new List<GameObject>();
    Camera cam;

    private void Start()
    {
    cam = Camera.main;
    }

    void Update()
    {
        if (Input. touchCount == 0)
            return;
        var touches = Input.touches;
        
        while (visualList.Count < touches.Length)
        {
        var visual = Instantiate(visualTemplate);
        visualList.Add(visual);
        }

    foreach (var visual in visualList)
        {
            visual. SetActive(false);
        }

    for (int i = 0; i < touches.Length; i++)
        {
            var touch = touches[i];
            var visual = visualList[i];
        }

            switch (touch.phase)
            {
                case TouchPhase.Began:
                case TouchPhase.Stationary:
                case TouchPhase.Moved:
                    visual.SetActive(true);
                    var worldPos = cam.ScreenToWorldPoint(touch.position);
                    worldPos.z = 0;
                    visual.transform.position = worldPos;
                    Debug.Log(touch.deItaPosition);
                    break ;
                case TouchPhase.Ended:
                case TouchPhase.Canceled:
                break;
            }
    }
}

    
