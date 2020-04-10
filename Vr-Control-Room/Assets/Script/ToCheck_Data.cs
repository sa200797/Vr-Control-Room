using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToCheck_Data : MonoBehaviour
{
    public TextMeshProUGUI d_name2;

    public TextMeshProUGUI postive_txt;
    public TextMeshProUGUI cured_txt;
    public TextMeshProUGUI death_txt;
 

    public KeralaData keralaData;

    // Start is called before the first frame update
    void Start()
    {
        keralaData = GameObject.Find("Manager").GetComponent<KeralaData>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;


        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.gameObject.tag == "Kd")
            {

                // gameObject.transform.position += new Vector3(0, 0, -15);


                d_name2.text = hit.transform.name.ToString();

                Debug.Log("Name12" + hit.collider);

                if (hit.transform.name == "0")
                {
                    Debug.Log("Name" + hit.collider);
                    postive_txt.text = keralaData.rootData.kerala.Kasaragod.corona_positive.ToString();
                    cured_txt.text = keralaData.rootData.kerala.Kasaragod.cured_discharged.ToString();
                    death_txt.text = keralaData.rootData.kerala.Kasaragod.cured_discharged.ToString();
                }

            }
        }
    }
}
