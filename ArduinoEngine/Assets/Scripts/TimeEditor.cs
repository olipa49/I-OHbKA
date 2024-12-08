using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeEditor : MonoBehaviour
{
    public void slowesttime()
    {
        Time.timeScale = 0.25f;
    }
    public void slowtime()
    {
        Time.timeScale = 0.5f;
    }

    public void normaltime()
    {
        Time.timeScale = 1.0f;
    }

    public void time2()
    {
        Time.timeScale = 2.0f;
    }

}
