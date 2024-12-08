using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temp_bar : MonoBehaviour
{
    Image TempBar;
    public float maxtemp = 100f;
    public float TP;
    void Start()
    {
        TempBar = GetComponent<Image>();
        TP = maxtemp;
    }

    // Update is called once per frame
    void Update()
    {
        TempBar.fillAmount = TP / maxtemp;
    }
}
