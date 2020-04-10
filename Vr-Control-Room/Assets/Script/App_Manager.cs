using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class App_Manager : MonoBehaviour
{
    public TextMeshProUGUI under_obs_Txt;
    public TextMeshProUGUI under_home_Txt;
    public TextMeshProUGUI total_hos_Txt;
    public TextMeshProUGUI hosp_tod__Txt;
    public TextMeshProUGUI corna_pos_Txt;
    public TextMeshProUGUI cured_dis_Txt;
    public TextMeshProUGUI death_Txt;



    public TextMeshProUGUI D_name;

    public TextMeshProUGUI D_name2;


    //public GameObject Data_obj;
    public KeralaData keralaData;
    // Start is called before the first frame update


    public GameObject db;
    void Start()
    {

       
        keralaData = GetComponent<KeralaData>();



    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void Alappuzha()
    {
       // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Alappuzha.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Alappuzha.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Alappuzha.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Alappuzha.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Alappuzha.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Alappuzha.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Alappuzha.deaths.ToString();

        D_name.text = "Alappuzha";
        D_name2.text = "Alappuzha";

    }

    public void Eranakulam()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Ernakulam.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Ernakulam.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Ernakulam.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Ernakulam.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Ernakulam.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Ernakulam.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Ernakulam.deaths.ToString();

        D_name.text = "Eranakulam";
         D_name2.text = "Eranakulam";
    }

    public void Idukki()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Idukki.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Idukki.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Idukki.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Idukki.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Idukki.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Idukki.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Idukki.deaths.ToString();

        D_name.text = "Idukki";
        D_name2.text = "Idukki";
    }

    public void Kannur()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Kannur.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Kannur.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Kannur.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Kannur.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Kannur.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Kannur.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Kannur.deaths.ToString();

        D_name.text = "Kannur";
        D_name2.text = "Kannur";
    }

    public void Kasaragod()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Kasaragod.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Kasaragod.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Kasaragod.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Kasaragod.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Kasaragod.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Kasaragod.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Kasaragod.deaths.ToString();

        D_name.text = "Kasaragod";
        D_name2.text = "Kasaragod";
    }

    public void Kollam()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Kollam.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Kollam.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Kollam.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Kollam.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Kollam.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Kollam.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Kollam.deaths.ToString();

        D_name.text = "Kollam";
        D_name2.text = "Kollam";
    }

    public void Kottayam()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Kottayam.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Kottayam.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Kottayam.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Kottayam.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Kottayam.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Kottayam.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Kottayam.deaths.ToString();

        D_name.text = "Kottayam";
        D_name2.text = "Kottayam";
    }

    public void Kozhikode()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Kozhikode.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Kozhikode.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Kozhikode.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Kozhikode.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Kozhikode.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Kozhikode.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Kozhikode.deaths.ToString();

        D_name.text = "Kozhikode";
        D_name2.text = "Kozhikode";
    }

    public void Malappuram()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Malappuram.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Malappuram.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Malappuram.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Malappuram.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Malappuram.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Malappuram.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Malappuram.deaths.ToString();

        D_name.text = "Malappuram";
        D_name2.text = "Malappuram";
    }

    public void Palakkad()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Palakkad.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Palakkad.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Palakkad.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Palakkad.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Palakkad.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Palakkad.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Palakkad.deaths.ToString();

        D_name.text = "Palakkad";
        D_name2.text = "Palakkad";
    }

    public void Pathanamthitta()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Pathanamthitta.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Pathanamthitta.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Pathanamthitta.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Pathanamthitta.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Pathanamthitta.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Pathanamthitta.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Pathanamthitta.deaths.ToString();

        D_name.text = "Pathanamthitta";
        D_name2.text = "Pathanamthitta";
    }


    public void Thiruvananthapuram()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Thiruvananthapuram.deaths.ToString();

        D_name.text = "Thiruvananthapuram";
        D_name2.text = "Thiruvananthapuram";
    }


    public void Wayanad()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Wayanad.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Wayanad.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Wayanad.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Wayanad.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Wayanad.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Wayanad.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Wayanad.deaths.ToString();

        D_name.text = "Wayanad";
        D_name2.text = "Wayanad";
    }

    public void Thrissur()
    {
        // under_obs_Txt.text= keralaData.Alappuzha.under_observation.ToString();

        under_obs_Txt.text = keralaData.rootData.kerala.Thrissur.under_observation.ToString();
        under_home_Txt.text = keralaData.rootData.kerala.Thrissur.under_home_isolation.ToString();
        total_hos_Txt.text = keralaData.rootData.kerala.Thrissur.total_hospitalised.ToString();
        hosp_tod__Txt.text = keralaData.rootData.kerala.Thrissur.hospitalised_today.ToString();
        corna_pos_Txt.text = keralaData.rootData.kerala.Thrissur.corona_positive.ToString();
        cured_dis_Txt.text = keralaData.rootData.kerala.Thrissur.cured_discharged.ToString();
        death_Txt.text = keralaData.rootData.kerala.Thrissur.deaths.ToString();


        D_name.text = "Thrissur";
        D_name2.text = "Thrissur";
    }


   
   
   






}
