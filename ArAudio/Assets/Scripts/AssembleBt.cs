using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssembleBt : MonoBehaviour
{
    private bool isunassembled = false;
    public Button signsbutton;
    public Slider scale;
    public GameObject audiocase;
    public GameObject podp;
    void Start()
    {
        isunassembled = false;
    }
    public void AssenbleButt()
    {
        if(isunassembled)
        {
            isunassembled = false;
            signsbutton.gameObject.SetActive(false);
            audiocase.SetActive(true);
            podp.SetActive(true);
        }
        else
        {
            isunassembled = true;
            signsbutton.gameObject.SetActive(true);
            audiocase.SetActive(false);
            podp.SetActive(false);
        }
        
    }
    public void targetlost()
    {
        isunassembled = false;
        scale.gameObject.SetActive(false);
        signsbutton.gameObject.SetActive(false);
        audiocase.SetActive(true);
        podp.SetActive(true);
    }
}
