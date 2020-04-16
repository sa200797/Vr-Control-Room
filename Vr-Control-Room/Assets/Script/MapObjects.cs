using Mapbox.Unity.Map;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MapObjects : MonoBehaviour
{

    public GameObject[] dis_marker;

    public GameObject[] hos_GameObject;



    public bool hos_obj;

    public bool m_obj;

    // Start is called before the first frame update
    [SerializeField]
    AbstractMap _map;


    void Start()
    {


        //m_obj = true;

        //hos_obj = true;


        _map = GameObject.Find("Map").GetComponent<AbstractMap>();
        
    }
    void Update()
    {
        hos_GameObject = GameObject.FindGameObjectsWithTag("Hospital");
        dis_marker = GameObject.FindGameObjectsWithTag("Kd");

        if (Input.GetKeyDown(KeyCode.O))
        {
            District_View();
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            onOFF_Facility();
        }


        if (Input.GetKeyDown(KeyCode.Z))
        {
            Zoom_In();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Zoom_out();
        }


    }


    public void District_View()
    {
        m_obj = !m_obj;

        
        foreach (GameObject m in dis_marker)
        {
            if (m_obj)
            {
                m.GetComponent<SphereCollider>().enabled = false;

                 m.transform.GetChild(0).GetComponentInChildren<SphereCollider>().enabled = false;
                m.transform.GetChild(0).GetComponentInChildren<MeshRenderer>().enabled = false;

                m.transform.GetChild(1).GetComponentInChildren<CapsuleCollider>().enabled = false;
                m.transform.GetChild(1).GetComponentInChildren<MeshRenderer>().enabled = false;







            }
            else
            {
                m.GetComponent<SphereCollider>().enabled = true;

                m.transform.GetChild(0).GetComponentInChildren<SphereCollider>().enabled = true;
                m.transform.GetChild(0).GetComponentInChildren<MeshRenderer>().enabled = true;

                m.transform.GetChild(1).GetComponentInChildren<CapsuleCollider>().enabled = true;
                m.transform.GetChild(1).GetComponentInChildren<MeshRenderer>().enabled = true;

                //  m.GetComponent<MeshRenderer>().enabled = true;

            }

        }
    }

    public void onOFF_Facility()
    {

       
        hos_obj = !hos_obj;

        foreach (GameObject h in hos_GameObject)
        {
            if (hos_obj)
            {
                h.GetComponent<BoxCollider>().enabled = false;
                h.GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                
                h.GetComponent<MeshRenderer>().enabled = true;
                h.GetComponent<BoxCollider>().enabled = true;
            }

        }
    }


    public void Zoom_In()
    {
        //_map.SetZoom(3.0f);
        _map._options.locationOptions.zoom += 2.0f;
        _map.UpdateMap();
    }


    public void Zoom_out()
    {
        _map._options.locationOptions.zoom -= 2.0f;
        _map.UpdateMap();
        // _map.SetZoom(-3.0f);
    }

    public void Reset_Zoom()
    {
        _map._options.locationOptions.zoom = 8.0f;
        _map.UpdateMap();
        // _map.SetZoom(-3.0f);
    }
}
