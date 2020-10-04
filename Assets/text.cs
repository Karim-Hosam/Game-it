using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class text : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject UiObject1;
    public GameObject UiObject2;
    public GameObject UiObject3;
    public GameObject UiObject4;
    public GameObject UiObject5;
    public GameObject UiObject6;
    public GameObject UiObject7;
    public GameObject UiObject8;
    public GameObject Cube;
    public Text textArea;
    // Start is called before the first frame update
    void Start()
    {
        UiObject1.SetActive(false);
        UiObject.SetActive(false);
        UiObject2.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {  
       UiObject.SetActive(true);
        UiObject1.SetActive(true);
        UiObject2.SetActive(true);
    }
    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
        UiObject1.SetActive(false);
        UiObject2.SetActive(false);
        UiObject3.SetActive(false);
        UiObject4.SetActive(false);
        UiObject5.SetActive(false);
        UiObject6.SetActive(false);
        UiObject7.SetActive(false);
        UiObject8.SetActive(false);
    }
    void Update()
        {
        float time = 0 + Time.time;

        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time - minutes * 60);

        string textTime = string.Format("{0:0}:{1:00}", minutes, seconds);

        textArea.text = textTime;
        }
}
