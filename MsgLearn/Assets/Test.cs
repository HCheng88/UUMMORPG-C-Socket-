﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {


	void Start () {
		
	}

	void Update () {
        Debug.Log( Input.GetAxis("Horizontal") +";" +Input.GetAxis("Vertical"));
    }
}
