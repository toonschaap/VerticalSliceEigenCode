﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deflect : MonoBehaviour
{
    GameObject DeflectableObject;
    public int deflectedSpeed;

    void Update()
    {


    }

    void OnTriggerEnter(Collider collision)
    {

        if (collision.gameObject.tag == "projectile" && Input.GetKey(KeyCode.K))
            {
                GameObject finder = GameObject.Find("DeflectableObject");
                finder.GetComponent<EyeballMovement>().InverseMovement();
                Debug.Log("collide");
            }
        }
    }
