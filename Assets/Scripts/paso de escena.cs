﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasodeescena : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void OnTriggerEnter2D(Collider2D other)
    { 
        if(other.gameObject.tag == "heroe")
        {
            SceneManager.LoadScene("room 2", LoadSceneMode.Single);
        }
    }
}
