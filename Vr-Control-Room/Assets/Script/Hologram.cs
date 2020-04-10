using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hologram : MonoBehaviour
{
    public Animator anim;
    public GameObject Kd;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        //  transform.Rotate(Vector3.right, speed * Time.deltaTime);
        transform.Rotate(new Vector3(0, 0, speed) * Time.deltaTime);
    }

    public void ShowMap()
    {
        anim.SetTrigger("go");
        StartCoroutine(Map_Show());
    }

    IEnumerator Map_Show()
    {
        
        yield return new WaitForSeconds(1.8f);
        Kd.SetActive(true);
           
    }
}
