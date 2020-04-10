using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Fun : MonoBehaviour
{


    public void Increase()
    {
        Debug.Log("Hello World");
        gameObject.transform.localScale = new Vector3(20,20,20 );
    }


    public void Decrease()
    {
        Debug.Log("Bye  World");
        gameObject.transform.localScale = new Vector3(15,15,15);
       
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
