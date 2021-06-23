using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChase : MonoBehaviour
{
    public Button signsbutton;
    public GameObject text;
    private bool isvisible=false;

    void Start()
    {
        text.SetActive(false);
        isvisible = false;
        signsbutton.onClick.AddListener(TaskOnClick);
    }
    void Update()
    {
        if(!signsbutton.gameObject.activeSelf)
        {
            isvisible = false;
            text.SetActive(false);
        }    
        text.transform.rotation = Quaternion.LookRotation(transform.position - Camera.main.transform.position);
    }
    void TaskOnClick()
    {
        if(isvisible)
        {
            isvisible = false;
            text.SetActive(false);
        }
        else
        {
            isvisible = true;
            text.SetActive(true);
        }
    }
    void Hidetext()
    {
        isvisible = false;
        text.SetActive(false);
    }
}
