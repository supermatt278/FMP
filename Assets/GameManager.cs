﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject player;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
			player.GetComponent<PlayerController>().Strafe = true;
            
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
			player.GetComponent<PlayerController>().Strafe = false;
            
        }
    }

    }
