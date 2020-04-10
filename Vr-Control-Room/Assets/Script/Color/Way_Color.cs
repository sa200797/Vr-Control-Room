using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Way_Color : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public KeralaData k_data;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        k_data = GameObject.Find("Manager").GetComponent<KeralaData>();

    }

    // Update is called once per frame
    void Update()
    {
        if (k_data.rootData.kerala.Wayanad.corona_positive <= 16)
        {
            spriteRenderer.color = new Color32(173, 216, 230, 255);
        }
        else if (k_data.rootData.kerala.Wayanad.corona_positive > 16 && k_data.rootData.kerala.Wayanad.corona_positive <= 32)
        {
            spriteRenderer.color = new Color32(135, 206, 250, 255);
        }
        else if (k_data.rootData.kerala.Wayanad.corona_positive > 32 && k_data.rootData.kerala.Wayanad.corona_positive <= 48)
        {
            spriteRenderer.color = new Color32(0, 191, 255, 255);
        }
        else if (k_data.rootData.kerala.Wayanad.corona_positive > 48 && k_data.rootData.kerala.Wayanad.corona_positive <= 64)
        {
            spriteRenderer.color = new Color32(65, 105, 225, 255);
        }
        else if (k_data.rootData.kerala.Wayanad.corona_positive > 64 && k_data.rootData.kerala.Wayanad.corona_positive <= 80)
        {
            spriteRenderer.color = new Color32(0, 0, 139, 255);
        }
        else if (k_data.rootData.kerala.Wayanad.corona_positive >= 80)
        {
            spriteRenderer.color = new Color32(25, 25, 112, 255);
        }
        else
        {
            spriteRenderer.color = Color.white;
        }



    }
}
