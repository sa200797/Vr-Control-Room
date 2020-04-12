using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name_Change : MonoBehaviour
{

    public string name_C;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.name = name_C;

       // Debug.Log("name::" + name_C);
    }

    // Update is called once per frame
    void Update()
    {
       // if(this.gameObject.name == " ")
       // {
       //     this.gameObject.name = name_C;
       // }
    }
}
