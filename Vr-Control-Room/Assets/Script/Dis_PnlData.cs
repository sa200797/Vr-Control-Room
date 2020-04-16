using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Mapbox.Examples;
using HighlightPlus;
//using System.Runtime.Remoting.Messaging;

public class Dis_PnlData : MonoBehaviour
{

    public Transform target;

    public GameObject data_pnl;

    public GameObject data_pnl2;


   

    public TextMeshProUGUI d_name2;


    public TextMeshProUGUI postive_txt;
    public TextMeshProUGUI cured_txt;
    public TextMeshProUGUI death_txt;

    public TextMeshProUGUI total_case_txt;

    public TextMeshProUGUI hos_name;
    public TextMeshProUGUI hos_localbdy;
    public TextMeshProUGUI hos_facType;
    public TextMeshProUGUI hos_number;
    public TextMeshProUGUI hos_cap;



    public long sT;


    public KeralaData keralaData;
    public KeralaFacility keralaFacility;

    public MapObj mapObjects;

    public HighlightEffect effect;



    [Header("Pannel Data")]

    public GameObject data_pnl3;


    public TextMeshProUGUI D_name;
    public TextMeshProUGUI under_obs_Txt;
    public TextMeshProUGUI under_home_Txt;
    public TextMeshProUGUI total_hos_Txt;
  //  public TextMeshProUGUI hosp_tod__Txt;
    public TextMeshProUGUI corna_pos_Txt;
    public TextMeshProUGUI cured_dis_Txt;
    public TextMeshProUGUI death_Txt;


    // Start is called before the first frame update
    void Start()
    {
        keralaData = GameObject.Find("Manager").GetComponent<KeralaData>();
        keralaFacility = GameObject.Find("Manager").GetComponent<KeralaFacility>();
        mapObjects = GameObject.Find("Map").GetComponent<MapObj>();


        data_pnl.SetActive(false);
        data_pnl2.SetActive(false);
        data_pnl3.SetActive(false);

    }

    // Update is called once per frame
     void Update()
    {
        

      //  Debug.DrawRay(transform.position,transform.forward, Color.green);
        RaycastHit hit;
       

        if(Physics.Raycast(transform.position,transform.forward,out hit))
        {

            




            if (hit.collider.gameObject.tag == "Kd")
            {
                effect = hit.collider.gameObject.GetComponent<HighlightEffect>();
                effect.highlighted = true;

                data_pnl.transform.position = hit.point + new Vector3(0, 8, 0);


                data_pnl.transform.rotation = Quaternion.LookRotation(data_pnl.transform.position - target.transform.position);
               // data_pnl.transform.LookAt(target);
               


                // gameObject.transform.position += new Vector3(0, 0, -15);


                d_name2.text = hit.transform.name.ToString();
                data_pnl.SetActive(true);

                data_pnl3.SetActive(true);
               
                if(hit.transform.name == "Kasargode")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kasaragod.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kasaragod.cured_discharged.ToString();
                    death_txt.text= keralaData.rootData.kerala.Kasaragod.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Kannur.under_observation.ToString(); 

                    Kasaragod();


                    total_Data(keralaData.rootData.kerala.Kasaragod.corona_positive, keralaData.rootData.kerala.Kasaragod.cured_discharged, keralaData.rootData.kerala.Kasaragod.deaths);

                }
                
                else if (hit.transform.name == "Kannur")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kannur.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kannur.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kannur.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Kannur.under_observation.ToString();

                    Kannur();

                    total_Data(keralaData.rootData.kerala.Kannur.corona_positive, keralaData.rootData.kerala.Kannur.cured_discharged, keralaData.rootData.kerala.Kannur.deaths);



                }
                else if(hit.transform.name == "Kozhikode")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kozhikode.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kozhikode.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kozhikode.deaths.ToString();
                    //  total_case_txt.text = keralaData.rootData.kerala.Kozhikode.under_observation.ToString();
                    
                    Kozhikode();

                    total_Data(keralaData.rootData.kerala.Kozhikode.corona_positive, keralaData.rootData.kerala.Kozhikode.cured_discharged, keralaData.rootData.kerala.Kozhikode.deaths);
                }
                else if(hit.transform.name == "Wayanad")
                {
                    postive_txt.text = keralaData.rootData.kerala.Wayanad.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Wayanad.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Wayanad.deaths.ToString();
                    //  total_case_txt.text = keralaData.rootData.kerala.Wayanad.under_observation.ToString();

                    Wayanad();

                    total_Data(keralaData.rootData.kerala.Wayanad.corona_positive, keralaData.rootData.kerala.Wayanad.cured_discharged, keralaData.rootData.kerala.Wayanad.deaths);
                }
                else if(hit.transform.name == "Malappuram")
                {
                    postive_txt.text = keralaData.rootData.kerala.Malappuram.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Malappuram.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Malappuram.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Malappuram.under_observation.ToString();

                    Malappuram();

                    total_Data(keralaData.rootData.kerala.Malappuram.corona_positive, keralaData.rootData.kerala.Malappuram.cured_discharged, keralaData.rootData.kerala.Malappuram.deaths);
                }
                else if (hit.transform.name == "Thrissur")
                {
                    postive_txt.text = keralaData.rootData.kerala.Thrissur.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Thrissur.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Thrissur.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Thrissur.under_observation.ToString();

                    Thrissur();

                    total_Data(keralaData.rootData.kerala.Thrissur.corona_positive, keralaData.rootData.kerala.Thrissur.cured_discharged, keralaData.rootData.kerala.Thrissur.deaths);
                }
                else if(hit.transform.name == "Palakkad")
                {
                    postive_txt.text = keralaData.rootData.kerala.Palakkad.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Palakkad.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Palakkad.deaths.ToString();
                    //  total_case_txt.text = keralaData.rootData.kerala.Palakkad.under_observation.ToString();

                    Palakkad();

                    total_Data(keralaData.rootData.kerala.Palakkad.corona_positive, keralaData.rootData.kerala.Palakkad.cured_discharged, keralaData.rootData.kerala.Palakkad.deaths);
                }
                else if (hit.transform.name == "Ernakulam")
                {
                    postive_txt.text = keralaData.rootData.kerala.Ernakulam.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Ernakulam.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Ernakulam.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Ernakulam.under_observation.ToString();

                    Ernakulam();


                    total_Data(keralaData.rootData.kerala.Ernakulam.corona_positive, keralaData.rootData.kerala.Ernakulam.cured_discharged, keralaData.rootData.kerala.Ernakulam.deaths);
                }
                else if(hit.transform.name == "Alappuzha")
                {
                    postive_txt.text = keralaData.rootData.kerala.Alappuzha.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Alappuzha.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Alappuzha.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Alappuzha.under_observation.ToString();

                    Alappuzha();

                    total_Data(keralaData.rootData.kerala.Alappuzha.corona_positive, keralaData.rootData.kerala.Alappuzha.cured_discharged, keralaData.rootData.kerala.Alappuzha.deaths);
                }
                else if (hit.transform.name == "Kottayam")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kottayam.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kottayam.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kottayam.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Kottayam.under_observation.ToString();

                    Kottayam();

                    total_Data(keralaData.rootData.kerala.Kottayam.corona_positive, keralaData.rootData.kerala.Kottayam.cured_discharged, keralaData.rootData.kerala.Kottayam.deaths);
                }
                else if(hit.transform.name == "Idukki")
                {
                    postive_txt.text = keralaData.rootData.kerala.Idukki.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Idukki.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Idukki.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Idukki.under_observation.ToString();

                    Idukki();

                    total_Data(keralaData.rootData.kerala.Idukki.corona_positive, keralaData.rootData.kerala.Idukki.cured_discharged, keralaData.rootData.kerala.Idukki.deaths);
                }
                else if(hit.transform.name == "Pathanamthitta")
                {
                    postive_txt.text = keralaData.rootData.kerala.Pathanamthitta.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Pathanamthitta.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Pathanamthitta.deaths.ToString();
                    // total_case_txt.text = keralaData.rootData.kerala.Pathanamthitta.under_observation.ToString();

                    Pathanamthitta();

                    total_Data(keralaData.rootData.kerala.Pathanamthitta.corona_positive, keralaData.rootData.kerala.Pathanamthitta.cured_discharged, keralaData.rootData.kerala.Pathanamthitta.deaths);
                }
                else if (hit.transform.name == "Kollam")
                {
                    postive_txt.text = keralaData.rootData.kerala.Kollam.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kollam.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kollam.deaths.ToString();
                    //total_case_txt.text = keralaData.rootData.kerala.Kollam.under_observation.ToString();


                    Kollam();

                    total_Data(keralaData.rootData.kerala.Kollam.corona_positive, keralaData.rootData.kerala.Kollam.cured_discharged, keralaData.rootData.kerala.Kollam.deaths);

                }
                else if(hit.transform.name == "Thiruvananthapuram")
                {
                    postive_txt.text = keralaData.rootData.kerala.Thiruvananthapuram.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Thiruvananthapuram.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Thiruvananthapuram.deaths.ToString();


                    Thiruvananthapuram();

                    total_Data(keralaData.rootData.kerala.Thiruvananthapuram.corona_positive, keralaData.rootData.kerala.Thiruvananthapuram.cured_discharged, keralaData.rootData.kerala.Thiruvananthapuram.deaths);

                }

            }
            else
            {

                // d_name2.text = " ";
                
            }



            if (hit.collider.gameObject.tag == "Hospital")
            {


               effect= hit.collider.gameObject.GetComponent<HighlightEffect>();
                effect.highlighted = true;
                

                data_pnl2.SetActive(true);
               // Debug.Log(hit.collider.name);
                data_pnl2.transform.position = hit.point + new Vector3(0, 8, 0);
                data_pnl2.transform.rotation = Quaternion.LookRotation(data_pnl2.transform.position - target.transform.position);

                for (int i = 0; i < mapObjects.id.Length; i++)
                {
                    if (hit.collider.name == keralaFacility.facRoot.results[i].id.ToString())
                     {
                          //  Debug.Log(hit.collider.name);
                           // Debug.Log(keralaFacility.facRoot.results[i].name.ToString());

                        hos_name.text = keralaFacility.facRoot.results[i].name.ToString();
                        hos_localbdy.text = keralaFacility.facRoot.results[i].local_body.ToString();
                        hos_facType.text = keralaFacility.facRoot.results[i].facility_type.ToString();
                        hos_number.text = keralaFacility.facRoot.results[i].phone_number.ToString();
                        hos_cap.text = keralaFacility.facRoot.results[i].oxygen_capacity.ToString();

                    }
            }

            }
            else
            {
               
                // data_pnl2.SetActive(false);
            }
                    
        }
        else
        {
            data_pnl.SetActive(false);
            data_pnl2.SetActive(false);

            if (effect != null)
            {
                effect.highlighted = false; 
            }
            
        }

    }


    public void total_Data(long a, long b, long c)
    {
        sT = (a + b + c);
        total_case_txt.text = sT.ToString();
    }





    #region Dis_Function
    public void Alappuzha()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Alappuzha.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Alappuzha.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Alappuzha.total_hospitalised.ToString();
      //  hosp_tod__Txt.text = keralaData.rootData.kerala.Alappuzha.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Alappuzha.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Alappuzha.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Alappuzha.deaths.ToString();

        D_name.text = "Alappuzha";
      //  D_name2.text = "Alappuzha";

    }

    public void Ernakulam()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Ernakulam.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Ernakulam.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Ernakulam.total_hospitalised.ToString();
       // hosp_tod__Txt.text = keralaData.rootData.kerala.Ernakulam.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Ernakulam.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Ernakulam.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Ernakulam.deaths.ToString();

        D_name.text = "Ernakulam";
       // D_name2.text = "Eranakulam";
    }

    public void Idukki()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Idukki.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Idukki.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Idukki.total_hospitalised.ToString();
     //   hosp_tod__Txt.text = keralaData.rootData.kerala.Idukki.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Idukki.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Idukki.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Idukki.deaths.ToString();

        D_name.text = "Idukki";
      //  D_name2.text = "Idukki";
    }

    public void Kannur()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Kannur.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Kannur.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Kannur.total_hospitalised.ToString();
        //hosp_tod__Txt.text = keralaData.rootData.kerala.Kannur.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Kannur.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Kannur.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Kannur.deaths.ToString();

        D_name.text = "Kannur";
       // D_name2.text = "Kannur";
    }

    public void Kasaragod()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Kasaragod.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Kasaragod.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Kasaragod.total_hospitalised.ToString();
      //  hosp_tod__Txt.text = keralaData.rootData.kerala.Kasaragod.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Kasaragod.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Kasaragod.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Kasaragod.deaths.ToString();

        D_name.text = "Kasaragod";
      ///  D_name2.text = "Kasaragod";
    }

    public void Kollam()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Kollam.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Kollam.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Kollam.total_hospitalised.ToString();
      //  hosp_tod__Txt.text = keralaData.rootData.kerala.Kollam.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Kollam.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Kollam.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Kollam.deaths.ToString();

        D_name.text = "Kollam";
       // D_name2.text = "Kollam";
    }

    public void Kottayam()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Kottayam.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Kottayam.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Kottayam.total_hospitalised.ToString();
      //  hosp_tod__Txt.text = keralaData.rootData.kerala.Kottayam.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Kottayam.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Kottayam.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Kottayam.deaths.ToString();

        D_name.text = "Kottayam";
       // D_name2.text = "Kottayam";
    }

    public void Kozhikode()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Kozhikode.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Kozhikode.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Kozhikode.total_hospitalised.ToString();
       // hosp_tod__Txt.text = keralaData.rootData.kerala.Kozhikode.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Kozhikode.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Kozhikode.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Kozhikode.deaths.ToString();

        D_name.text = "Kozhikode";
       // D_name2.text = "Kozhikode";
    }

    public void Malappuram()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Malappuram.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Malappuram.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Malappuram.total_hospitalised.ToString();
     //   hosp_tod__Txt.text = keralaData.rootData.kerala.Malappuram.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Malappuram.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Malappuram.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Malappuram.deaths.ToString();

        D_name.text = "Malappuram";
      //  D_name2.text = "Malappuram";
    }

    public void Palakkad()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Palakkad.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Palakkad.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Palakkad.total_hospitalised.ToString();
      //  hosp_tod__Txt.text = keralaData.rootData.kerala.Palakkad.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Palakkad.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Palakkad.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Palakkad.deaths.ToString();

        D_name.text = "Palakkad";
       // D_name2.text = "Palakkad";
    }

    public void Pathanamthitta()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Pathanamthitta.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Pathanamthitta.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Pathanamthitta.total_hospitalised.ToString();
       // hosp_tod__Txt.text = keralaData.rootData.kerala.Pathanamthitta.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Pathanamthitta.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Pathanamthitta.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Pathanamthitta.deaths.ToString();

        D_name.text = "Pathanamthitta";
        //D_name2.text = "Pathanamthitta";
    }


    public void Thiruvananthapuram()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.total_hospitalised.ToString();
     //   hosp_tod__Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.deaths.ToString();

        D_name.text = "Thiruvananthapuram";
      //  D_name2.text = "Thiruvananthapuram";
    }


    public void Wayanad()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Wayanad.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Wayanad.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Wayanad.total_hospitalised.ToString();
       // hosp_tod__Txt.text = keralaData.rootData.kerala.Wayanad.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Wayanad.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Wayanad.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Wayanad.deaths.ToString();

        D_name.text = "Wayanad";
       // D_name2.text = "Wayanad";
    }

    public void Thrissur()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Thrissur.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Thrissur.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Thrissur.total_hospitalised.ToString();
       /// hosp_tod__Txt.text = keralaData.rootData.kerala.Thrissur.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Thrissur.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Thrissur.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Thrissur.deaths.ToString();


        D_name.text = "Thrissur";
        //D_name2.text = "Thrissur";
    }


#endregion
}
