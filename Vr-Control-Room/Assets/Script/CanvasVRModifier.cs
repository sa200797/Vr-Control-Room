using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;

public class CanvasVRModifier : MonoBehaviour
{

    public GameObject pointer;
    private void Awake()
    {
        GraphicRaycaster gr = GetComponent<GraphicRaycaster>();
        OVRRaycaster OVRrc = null;
        if (gr != null)
        {
            gr.enabled = false;
            OVRrc = gameObject.AddComponent<OVRRaycaster>();
            OVRrc.pointer = pointer;
            OVRrc.blockingObjects = OVRRaycaster.BlockingObjects.All;
        }

    }

        // Start is called before the first frame update
        void Start()
    {

    }

    // Update is called once per frame

    private void Update()
    {
        if (XRSettings.isDeviceActive)
        {
            var found = gameObject.GetComponentsInChildren<GraphicRaycaster>();
            foreach (var gr in found)
            {
                var ovr = gr.GetComponent<OVRRaycaster>();
                if (ovr == null)
                {
                    gr.enabled = false;
                    ovr = gr.gameObject.AddComponent<OVRRaycaster>();
                    ovr.sortOrder = 20;
                }
            }
        }
    }
}