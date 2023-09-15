using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeDisplay;

    float currentTime = 0f;

    private void Update()
    {
        currentTime += Time.deltaTime;

        timeDisplay.text = $"Time : {Mathf.Round(currentTime)}s";
    }
}
