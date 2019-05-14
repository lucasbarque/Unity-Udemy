using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public bool liberaRot;
    public GameObject ima;

    // Start is called before the first frame update
    void Start()
    {
        liberaRot = false;   
    }

    // Update is called once per frame
    void Update()
    {
        if (liberaRot)
        {
            ima.gameObject.transform.Rotate(new Vector3(0, 0, 5 * Time.deltaTime));
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pato"))
        {
            liberaRot = true;
        }   
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pato"))
        {
            liberaRot = false;
        }
    }
}
