using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erna_Color : MonoBehaviour
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
        if (k_data.rootData.kerala.Kasaragod.corona_positive <= 16)
        {
            spriteRenderer.color = new Color32(225, 237, 255, 255);
        }
        else if (k_data.rootData.kerala.Kasaragod.corona_positive > 16 && k_data.rootData.kerala.Kasaragod.corona_positive <= 32)
        {
            spriteRenderer.color = new Color32(197, 220, 254, 255);
        }
        else if (k_data.rootData.kerala.Kasaragod.corona_positive > 32 && k_data.rootData.kerala.Kasaragod.corona_positive <= 48)
        {
            spriteRenderer.color = new Color32(144, 189, 255, 255);
        }
        else if (k_data.rootData.kerala.Kasaragod.corona_positive > 48 && k_data.rootData.kerala.Kasaragod.corona_positive <= 64)
        {
            spriteRenderer.color = new Color32(89, 156, 255, 255);
        }
        else if (k_data.rootData.kerala.Kasaragod.corona_positive > 64 && k_data.rootData.kerala.Kasaragod.corona_positive <= 80)
        {
            spriteRenderer.color = new Color32(48, 121, 231, 255);
        }
        else if (k_data.rootData.kerala.Kasaragod.corona_positive >= 80)
        {
            spriteRenderer.color = new Color32(23, 91, 193, 255);
        }
        else
        {
            spriteRenderer.color = Color.white;
        }



    }
}
