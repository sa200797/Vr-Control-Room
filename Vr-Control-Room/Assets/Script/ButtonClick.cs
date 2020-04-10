using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using HighlightPlus;

public class ButtonClick : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject data_pnl;

   
    public TextMeshProUGUI d_name2;


    public TextMeshProUGUI postive_txt;
    public TextMeshProUGUI cured_txt;
    public TextMeshProUGUI death_txt;
    public TextMeshProUGUI total_case_txt;




    public GameObject Earth;
    public HighlightEffect effect;
   

    public KeralaData keralaData;


    void Start()
    {
        Earth = GameObject.FindGameObjectWithTag("Earth");
       effect = Earth.GetComponent<HighlightEffect>();


       
        keralaData = GameObject.Find("Manager").GetComponent<KeralaData>();

    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.DrawRay(transform.position,transform.forward, Color.green);
        RaycastHit hit;
       

        if(Physics.Raycast(transform.position,transform.forward,out hit))
        {
            if(hit.collider.gameObject.tag == "Kd")
            {

                // gameObject.transform.position += new Vector3(0, 0, -15);
                

                d_name2.text = hit.transform.name.ToString();
                data_pnl.SetActive(true);              
                if(hit.transform.name == "Kasargode")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kasaragod.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kasaragod.cured_discharged.ToString();
                    death_txt.text= keralaData.rootData.kerala.Kasaragod.cured_discharged.ToString(); ;
                }
                
                else if (hit.transform.name == "Kannur")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kannur.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kannur.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kannur.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Kannur.under_observation.ToString();
                }
                else if(hit.transform.name == "Kozhikode")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kozhikode.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kozhikode.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kozhikode.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Kozhikode.under_observation.ToString();
                }
                else if(hit.transform.name == "Wayanad")
                {
                    postive_txt.text = keralaData.rootData.kerala.Wayanad.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Wayanad.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Wayanad.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Wayanad.under_observation.ToString();
                }
                else if(hit.transform.name == "Malappuram")
                {
                    postive_txt.text = keralaData.rootData.kerala.Malappuram.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Malappuram.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Malappuram.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Malappuram.under_observation.ToString();
                }
                else if (hit.transform.name == "Thrissur")
                {
                    postive_txt.text = keralaData.rootData.kerala.Thrissur.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Thrissur.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Thrissur.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Thrissur.under_observation.ToString();
                }
                else if(hit.transform.name == "Palakkad")
                {
                    postive_txt.text = keralaData.rootData.kerala.Palakkad.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Palakkad.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Palakkad.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Palakkad.under_observation.ToString();
                }
                else if (hit.transform.name == "Ernakulam")
                {
                    postive_txt.text = keralaData.rootData.kerala.Ernakulam.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Ernakulam.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Ernakulam.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Ernakulam.under_observation.ToString();
                }
                else if(hit.transform.name == "Alappuzha")
                {
                    postive_txt.text = keralaData.rootData.kerala.Alappuzha.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Alappuzha.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Alappuzha.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Alappuzha.under_observation.ToString();
                }
                else if (hit.transform.name == "Kottayam")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kottayam.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kottayam.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kottayam.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Kottayam.under_observation.ToString();
                }
                else if(hit.transform.name == "Idukki")
                {
                    postive_txt.text = keralaData.rootData.kerala.Idukki.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Idukki.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Idukki.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Idukki.under_observation.ToString();
                }
                else if(hit.transform.name == "Pathanamthitta")
                {
                    postive_txt.text = keralaData.rootData.kerala.Pathanamthitta.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Pathanamthitta.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Pathanamthitta.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Pathanamthitta.under_observation.ToString();
                }
                else if (hit.transform.name == "Kollam")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kollam.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kollam.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kollam.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Kollam.under_observation.ToString();

                }
                else if(hit.transform.name == "Thiruvananthapuram")
                {
                    postive_txt.text = keralaData.rootData.kerala.Thiruvananthapuram.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Thiruvananthapuram.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Thiruvananthapuram.cured_discharged.ToString();
                    total_case_txt.text = keralaData.rootData.kerala.Thiruvananthapuram.under_observation.ToString();
                }

            }
            else
            {
                data_pnl.SetActive(false);
               // d_name2.text = " ";
            }


            if (hit.collider.gameObject.tag == "Earth")
            {
                effect.highlighted = true;

               // effect.outline = 1f;
               // effect.outlineColor = Color.red;
               // effect.UpdateMaterialProperties();
            }
            


        }
        else
        {
            effect.highlighted = false;
        }

    }
}
