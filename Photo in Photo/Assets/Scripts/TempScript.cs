﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempScript : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnMouseDown() {
		Debug.Log (gameObject.name);
	}

	void OnMouseDrag() {
		Debug.Log (gameObject.name);
	}


}