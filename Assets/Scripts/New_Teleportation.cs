using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_Teleportation : MonoBehaviour
{
    public GameObject player;
    public GameObject newplayer;
    public float x_axis;
    public float y_axis;


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "teleport")
        {
            Destroy(gameObject);
            Instantiate(newplayer, new Vector3(x_axis, y_axis, 0), transform.rotation);
        }
    }



}
