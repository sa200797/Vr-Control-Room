using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pan_Map : MonoBehaviour
{
    //public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
      //  rb = GetComponent<Rigidbody>();

    }
    
    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.DpadUp) || Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * Time.deltaTime *350;
        }
        if (OVRInput.Get(OVRInput.Button.DpadDown) || Input.GetKey(KeyCode.S))
        {
            transform.position -= Vector3.forward * Time.deltaTime *350;
        }
        if (OVRInput.Get(OVRInput.Button.DpadLeft) || Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * Time.deltaTime *350;
        }
        if (OVRInput.Get(OVRInput.Button.DpadRight) || Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * Time.deltaTime *350;
        }
    }
}
