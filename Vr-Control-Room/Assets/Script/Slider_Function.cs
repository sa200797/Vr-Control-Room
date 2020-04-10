using OVR.OpenVR;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slider_Function : MonoBehaviour
{
    public Slider z_slider;

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //if(OVRInput.Get(OVRInput.Touch.One) || Input.GetKeyDown(KeyCode.O))
        //{
        //      z_slider.value -=  5;

        //}

        //if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickRight) || Input.GetKeyDown(KeyCode.P))
        //  {
        //      z_slider.value +=   5;
        //  }

        if (OVRInput.Get(OVRInput.Button.PrimaryTouchpad))
        {
            Vector2 primaryTouchpad = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
            if (primaryTouchpad.x > 0f)
            {
                NextWeapon();
            }
            else if (primaryTouchpad.x < 0f)
            {
                PreviousWeapon();
            }
        }

    }

    public void NextWeapon()
    {
        z_slider.value += 5;
    }

    public void PreviousWeapon()
    {
        z_slider.value -= 5;
    }


}
