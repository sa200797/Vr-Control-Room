using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DIspay_StateData : MonoBehaviour
{
    public KeralaData keralaData;


    [Header("Kerala Data")]
    public TextMeshProUGUI posCase_text;
    public TextMeshProUGUI Re_Covred_Case_text;
    public TextMeshProUGUI DeathCase_text;

    [Header("Kasargod Data")]
    public TextMeshProUGUI Ka_posCase_text;
    public TextMeshProUGUI Ka_Re_Covred_Case_text;
    public TextMeshProUGUI Ka_DeathCase_text;

    [Header("Kannur Data")]
    public TextMeshProUGUI Kan_posCase_text;
    public TextMeshProUGUI Kan_Re_Covred_Case_text;
    public TextMeshProUGUI Kan_DeathCase_text;

    [Header("Wayand Data")]
    public TextMeshProUGUI Way_posCase_text;
    public TextMeshProUGUI Way_Re_Covred_Case_text;
    public TextMeshProUGUI Way_DeathCase_text;

    [Header("Kozhikode Data")]
    public TextMeshProUGUI Koz_posCase_text;
    public TextMeshProUGUI Koz_Re_Covred_Case_text;
    public TextMeshProUGUI Koz_DeathCase_text;

    [Header("Malappuram Data")]
    public TextMeshProUGUI Mal_posCase_text;
    public TextMeshProUGUI Mal_Re_Covred_Case_text;
    public TextMeshProUGUI Mal_DeathCase_text;

    [Header("Palakkad Data")]
    public TextMeshProUGUI Pal_posCase_text;
    public TextMeshProUGUI Pal_Re_Covred_Case_text;
    public TextMeshProUGUI Pal_DeathCase_text;

    [Header("Thrissur Data")]
    public TextMeshProUGUI This_posCase_text;
    public TextMeshProUGUI This_Re_Covred_Case_text;
    public TextMeshProUGUI This_DeathCase_text;

    [Header("Ernakulam Data")]
    public TextMeshProUGUI Era_posCase_text;
    public TextMeshProUGUI Era_Re_Covred_Case_text;
    public TextMeshProUGUI Era_DeathCase_text;

    // Start is called before the first frame update
    void Start()
    {
        keralaData = GetComponent<KeralaData>();


       
        
    }


    // Update is called once per frame
    void Update()
    {
        #region Kasargod


        Ka_posCase_text.text = keralaData.rootData.kerala.Kasaragod.corona_positive.ToString();
        Ka_Re_Covred_Case_text.text = keralaData.rootData.kerala.Kasaragod.cured_discharged.ToString();
        Ka_DeathCase_text.text = keralaData.rootData.kerala.Kasaragod.deaths.ToString();


        #endregion

        #region Kannur


        Kan_posCase_text.text = keralaData.rootData.kerala.Kannur.corona_positive.ToString();
        Kan_Re_Covred_Case_text.text = keralaData.rootData.kerala.Kannur.cured_discharged.ToString();
        Kan_DeathCase_text.text = keralaData.rootData.kerala.Kannur.deaths.ToString();


        #endregion

        #region Wayand


        Way_posCase_text.text = keralaData.rootData.kerala.Wayanad.corona_positive.ToString();
        Way_Re_Covred_Case_text.text = keralaData.rootData.kerala.Wayanad.cured_discharged.ToString();
        Way_DeathCase_text.text = keralaData.rootData.kerala.Wayanad.deaths.ToString();


        #endregion

        #region Kozhikode


        Koz_posCase_text.text = keralaData.rootData.kerala.Kozhikode.corona_positive.ToString();
        Koz_Re_Covred_Case_text.text = keralaData.rootData.kerala.Kozhikode.cured_discharged.ToString();
        Koz_DeathCase_text.text = keralaData.rootData.kerala.Kozhikode.deaths.ToString();


        #endregion

        #region Malappuram


        Mal_posCase_text.text = keralaData.rootData.kerala.Malappuram.corona_positive.ToString();
        Mal_Re_Covred_Case_text.text = keralaData.rootData.kerala.Malappuram.cured_discharged.ToString();
        Mal_DeathCase_text.text = keralaData.rootData.kerala.Malappuram.deaths.ToString();


        #endregion

        #region Palakkad


        Pal_posCase_text.text = keralaData.rootData.kerala.Palakkad.corona_positive.ToString();
        Pal_Re_Covred_Case_text.text = keralaData.rootData.kerala.Palakkad.cured_discharged.ToString();
        Pal_DeathCase_text.text = keralaData.rootData.kerala.Palakkad.deaths.ToString();


        #endregion

        #region Thrissur


        This_posCase_text.text = keralaData.rootData.kerala.Thrissur.corona_positive.ToString();
        This_Re_Covred_Case_text.text = keralaData.rootData.kerala.Thrissur.cured_discharged.ToString();
        This_DeathCase_text.text = keralaData.rootData.kerala.Thrissur.deaths.ToString();


        #endregion

        #region Ernakulam


        Era_posCase_text.text = keralaData.rootData.kerala.Ernakulam.corona_positive.ToString();
        Era_Re_Covred_Case_text.text = keralaData.rootData.kerala.Ernakulam.cured_discharged.ToString();
        Era_DeathCase_text.text = keralaData.rootData.kerala.Ernakulam.deaths.ToString();


        #endregion

    }
}
