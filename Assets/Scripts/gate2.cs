﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gate2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision) //collide funtion with the door
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(5); //load the scene 5 after collision
        }
    }
}
