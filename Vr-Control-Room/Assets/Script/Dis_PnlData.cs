using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dis_PnlData : MonoBehaviour
{
    public GameObject data_pnl;


    public TextMeshProUGUI d_name2;


    public TextMeshProUGUI postive_txt;
    public TextMeshProUGUI cured_txt;
    public TextMeshProUGUI death_txt;

    public TextMeshProUGUI total_case_txt;

    public long sT;


    public KeralaData keralaData;

    // Start is called before the first frame update
    void Start()
    {
        keralaData = GameObject.Find("Manager").GetComponent<KeralaData>();

        data_pnl.SetActive(false);
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
                    death_txt.text= keralaData.rootData.kerala.Kasaragod.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Kannur.under_observation.ToString(); 

                    total_Data(keralaData.rootData.kerala.Kasaragod.corona_positive, keralaData.rootData.kerala.Kasaragod.cured_discharged, keralaData.rootData.kerala.Kasaragod.deaths);

                }
                
                else if (hit.transform.name == "Kannur")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kannur.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kannur.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kannur.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Kannur.under_observation.ToString();


                    total_Data(keralaData.rootData.kerala.Kannur.corona_positive, keralaData.rootData.kerala.Kannur.cured_discharged, keralaData.rootData.kerala.Kannur.deaths);



                }
                else if(hit.transform.name == "Kozhikode")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kozhikode.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kozhikode.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kozhikode.deaths.ToString();
                    //  total_case_txt.text = keralaData.rootData.kerala.Kozhikode.under_observation.ToString();

                    total_Data(keralaData.rootData.kerala.Kozhikode.corona_positive, keralaData.rootData.kerala.Kozhikode.cured_discharged, keralaData.rootData.kerala.Kozhikode.deaths);
                }
                else if(hit.transform.name == "Wayanad")
                {
                    postive_txt.text = keralaData.rootData.kerala.Wayanad.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Wayanad.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Wayanad.deaths.ToString();
                    //  total_case_txt.text = keralaData.rootData.kerala.Wayanad.under_observation.ToString();

                    total_Data(keralaData.rootData.kerala.Wayanad.corona_positive, keralaData.rootData.kerala.Wayanad.cured_discharged, keralaData.rootData.kerala.Wayanad.deaths);
                }
                else if(hit.transform.name == "Malappuram")
                {
                    postive_txt.text = keralaData.rootData.kerala.Malappuram.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Malappuram.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Malappuram.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Malappuram.under_observation.ToString();

                    total_Data(keralaData.rootData.kerala.Malappuram.corona_positive, keralaData.rootData.kerala.Malappuram.cured_discharged, keralaData.rootData.kerala.Malappuram.deaths);
                }
                else if (hit.transform.name == "Thrissur")
                {
                    postive_txt.text = keralaData.rootData.kerala.Thrissur.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Thrissur.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Thrissur.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Thrissur.under_observation.ToString();

                    total_Data(keralaData.rootData.kerala.Thrissur.corona_positive, keralaData.rootData.kerala.Thrissur.cured_discharged, keralaData.rootData.kerala.Thrissur.deaths);
                }
                else if(hit.transform.name == "Palakkad")
                {
                    postive_txt.text = keralaData.rootData.kerala.Palakkad.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Palakkad.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Palakkad.deaths.ToString();
                    //  total_case_txt.text = keralaData.rootData.kerala.Palakkad.under_observation.ToString();

                    total_Data(keralaData.rootData.kerala.Palakkad.corona_positive, keralaData.rootData.kerala.Palakkad.cured_discharged, keralaData.rootData.kerala.Palakkad.deaths);
                }
                else if (hit.transform.name == "Ernakulam")
                {
                    postive_txt.text = keralaData.rootData.kerala.Ernakulam.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Ernakulam.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Ernakulam.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Ernakulam.under_observation.ToString();

                    total_Data(keralaData.rootData.kerala.Ernakulam.corona_positive, keralaData.rootData.kerala.Ernakulam.cured_discharged, keralaData.rootData.kerala.Ernakulam.deaths);
                }
                else if(hit.transform.name == "Alappuzha")
                {
                    postive_txt.text = keralaData.rootData.kerala.Alappuzha.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Alappuzha.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Alappuzha.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Alappuzha.under_observation.ToString();

                    total_Data(keralaData.rootData.kerala.Alappuzha.corona_positive, keralaData.rootData.kerala.Alappuzha.cured_discharged, keralaData.rootData.kerala.Alappuzha.deaths);
                }
                else if (hit.transform.name == "Kottayam")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kottayam.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kottayam.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kottayam.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Kottayam.under_observation.ToString();

                    total_Data(keralaData.rootData.kerala.Kottayam.corona_positive, keralaData.rootData.kerala.Kottayam.cured_discharged, keralaData.rootData.kerala.Kottayam.deaths);
                }
                else if(hit.transform.name == "Idukki")
                {
                    postive_txt.text = keralaData.rootData.kerala.Idukki.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Idukki.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Idukki.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Idukki.under_observation.ToString();

                    total_Data(keralaData.rootData.kerala.Idukki.corona_positive, keralaData.rootData.kerala.Idukki.cured_discharged, keralaData.rootData.kerala.Idukki.deaths);
                }
                else if(hit.transform.name == "Pathanamthitta")
                {
                    postive_txt.text = keralaData.rootData.kerala.Pathanamthitta.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Pathanamthitta.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Pathanamthitta.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Pathanamthitta.under_observation.ToString();

                    total_Data(keralaData.rootData.kerala.Pathanamthitta.corona_positive, keralaData.rootData.kerala.Pathanamthitta.cured_discharged, keralaData.rootData.kerala.Pathanamthitta.deaths);
                }
                else if (hit.transform.name == "Kollam")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kollam.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kollam.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kollam.deaths.ToString();
                    //total_case_txt.text = keralaData.rootData.kerala.Kollam.under_observation.ToString();


                    total_Data(keralaData.rootData.kerala.Kollam.corona_positive, keralaData.rootData.kerala.Kollam.cured_discharged, keralaData.rootData.kerala.Kollam.deaths);

                }
                else if(hit.transform.name == "Thiruvananthapuram")
                {
                    postive_txt.text = keralaData.rootData.kerala.Thiruvananthapuram.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Thiruvananthapuram.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Thiruvananthapuram.deaths.ToString();


                    total_Data(keralaData.rootData.kerala.Thiruvananthapuram.corona_positive, keralaData.rootData.kerala.Thiruvananthapuram.cured_discharged, keralaData.rootData.kerala.Thiruvananthapuram.deaths);

                }

            }
            else
            {
               
               // d_name2.text = " ";
            }


            
            


        }
        else
        {
            data_pnl.SetActive(false);
        }

    }


    public void total_Data(long a, long b, long c)
    {
        sT = (a + b + c);
        total_case_txt.text = sT.ToString();
    }
}
