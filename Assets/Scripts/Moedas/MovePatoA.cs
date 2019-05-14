﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePatoA : MonoBehaviour
{

    public float vel = 2.5f;
    public int moedas = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector2(vel * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector2(-vel * Time.deltaTime, 0));
        }

        print(moedas);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("moeda"))
        {
            moedas++;
            Destroy(collision.gameObject);
        }   
    }
}
