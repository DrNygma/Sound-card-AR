using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Resizer : MonoBehaviour
{
    public GameObject audiocard;
    public Slider slider;

    public float scale = 0.05f;

    public void ScaleResolution()
    {
        audiocard.transform.localScale = new Vector3(scale * slider.value, scale * slider.value, scale * slider.value);
    }
}
