using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplicaForca : MonoBehaviour
{
    public float forca = 200f;
    public Rigidbody2D bola;
    public bool liberaPulo = false;
    public int duplo = 2;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(duplo > 0) { 
            if (this.gameObject.CompareTag("bola"))
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    bola.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);
                    duplo--;
                }
            }
        }
        //if (liberaPulo)
        //{
        //    if (this.gameObject.CompareTag("bola"))
        //    {
        //        if (Input.GetKeyDown(KeyCode.Space))
        //        {
        //            bola.AddForce(new Vector2(0, forca * Time.deltaTime), ForceMode2D.Impulse);
        //        }
        //    }
        //}
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            duplo = 2;
            liberaPulo = true;
        }    
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chao"))
        {
            liberaPulo = false;
        }
    }
}
