using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed_scale : MonoBehaviour
{
    Image SpeedBar;
    public float maxspeed = 100f;
    public float SD;
    void Start()
    {
        SpeedBar = GetComponent<Image>();
        SD = maxspeed;
    }

    // Update is called once per frame
    void Update()
    {
        SpeedBar.fillAmount = SD / maxspeed;
    }
}
