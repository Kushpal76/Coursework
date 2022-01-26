using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 0;
    [SerializeField] public Text timeText;

    private void Update()
    {
        time = Time.deltaTime + time;
        //This calcuates the amount of time that has passed by adding the time
        //previously taken and the time since the last time the update function was called

        DisplayTime(time);
    }

    private void DisplayTime(float Display)
    {
        float minutes = Mathf.FloorToInt(Display / 60);
        float seconds = Mathf.FloorToInt(Display % 60);
        //These two lines work out the miniutes and seconds taken using divide and modulus

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        //This line formats the time so it looks nicer on the screen
    }
}
