using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


using TMPro;

[System.Serializable]
public class LocationData
{
    public double latitude;
    public double longitude;
}

[System.Serializable]
public class FacilityData
{
    public string name;
    public string local_body;
    public string facility_type;
    public string address;
    public string phone_number;

    public int id;
    public int oxygen_capacity;

    public LocationData location;

    
}

[System.Serializable]
public class FacilityRoot
{
    public FacilityData[] results;
}

public class KeralaFacility : MonoBehaviour
{
    public FacilityRoot facRoot;

    
    public string districtName;

    private string uriLoc = "https://api.care.coronasafe.in/api/v1/facility/";
    private string urlFacility;


  

    


    public void Start()
    {
       // KeralaFacilities();

        Debug.Log(facRoot.results.Length+"Shubham");      
        
    }
    public void KeralaFacilities()
    {
        if (districtName != null)
        {
            urlFacility = uriLoc + "?district_name=" + districtName;
            Debug.Log(urlFacility);
        }
        else
        {
            urlFacility = uriLoc;
        }

        StartCoroutine(GetLocation());
    }

    private IEnumerator GetLocation()
    {
        UnityWebRequest reqLoc = new UnityWebRequest(urlFacility, "GET");

        DownloadHandlerBuffer dBuff = new DownloadHandlerBuffer();
        reqLoc.downloadHandler = dBuff;

        reqLoc.SetRequestHeader("Authorization", "Basic ZGV2c3RhZmZ0ZXN0ZXI6RGV2VGVzdGVyU3RhZmZAMTIz");
        yield return reqLoc.SendWebRequest();

        if (!reqLoc.isNetworkError)
        {
            Debug.Log(reqLoc.responseCode);

            string loc = reqLoc.downloadHandler.text;

            facRoot = JsonUtility.FromJson<FacilityRoot>(loc);

            Debug.Log(facRoot.results[0].name);
        }
        else
        {
            Debug.Log(reqLoc.responseCode);
            Debug.Log(reqLoc.error);
        }
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            HandleInputData(13);
        }
    }

    public void HandleInputData(int val)
    {
        if(val== 0)
        {
            districtName ="Kasargode";
            KeralaFacilities();

        }
        if (val == 1)
        {
            districtName = "Kannur";
            KeralaFacilities();

        }
        if (val == 2)
        {
            districtName = "Kozhikode";
            KeralaFacilities();

        }
        if (val == 3)
        {
            districtName = "Wayanad";
            KeralaFacilities();

        }
        if (val == 4)
        {
            districtName = "Malappuram";
            KeralaFacilities();

        }
        if (val == 5)
        {
            districtName = "Thrissur ";
            KeralaFacilities();

        }
        if (val == 6)
        {
            districtName = "Palakkad";
            KeralaFacilities();

        }
        if (val == 7)
        {
            districtName = "Ernakulam";
            KeralaFacilities();

        }
        if (val == 8)
        {
            districtName = "Alappuzha";
            KeralaFacilities();

        }
        if (val == 9)
        {
            districtName = "Kottayam";
            KeralaFacilities();

        }
        if (val == 10)
        {
            districtName = "Idukki";
            KeralaFacilities();

        }
        if (val == 11)
        {
            districtName = "Pathanamthitta";
            KeralaFacilities();

        }
        if (val == 12)
        {
            districtName = "Kollam";
            KeralaFacilities();

        }
        if (val == 13)
        {
            districtName = "Thiruvananthapuram";
            KeralaFacilities();

        }




    }
}
