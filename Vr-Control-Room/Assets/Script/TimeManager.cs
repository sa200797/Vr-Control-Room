using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TimeManager : MonoBehaviour
{
    // Start is called before the first frame update

    public float totalTime;


    float timeLeft = 15;


    public Image time_Img;
    public TextMeshProUGUI Time_text;



    // Start is called before the first frame update
    void Start()
    {

       

    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        Time_text.text = (timeLeft).ToString("0");
       //  time_Img.fillAmount -= 1.0f / timeLeft * Time.deltaTime;

        time_Img.fillAmount -= 1.0f / 15 * Time.deltaTime;


        if (timeLeft <= 0)
        {
           SceneManager.LoadScene(1);
            //Do something useful or Load a new game scene depending on your use-case
        }
    }
}
