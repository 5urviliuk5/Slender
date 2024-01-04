using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public bool isOn;
    public Light light;
    public AudioSource source;
    public float percents = 100f;
    public float decreaseRate = 1f;
    public TMP_Text text;

    void Update()
    {
        light.enabled = isOn;

        if (Input.GetKeyDown(KeyCode.E))
        {
            isOn = !isOn;
            
            source.Play();
        }

        if (isOn == true)
        {
            percents -= decreaseRate * Time.deltaTime;
            percents = Mathf.Max(percents, 0f);
            text.text = ("Battery: ") + percents.ToString() + ("%");

            if (percents <= 0)
            {
                isOn = !isOn;
            }
        }
    }
}
