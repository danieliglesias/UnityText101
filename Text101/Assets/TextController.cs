﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour {
	
	public Text text;
	// Use this for initialization
	void Start () {
			text.text = "HELLO WORLD";
	}
	
	// Update is called once per frame
	void Update () {
	
	if (Input.GetKeyDown(KeyCode.Space)) {
	
		text.text = "SPACE PRESSED";

		}
	
	}
}
