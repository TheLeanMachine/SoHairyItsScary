﻿using UnityEngine;
using System.Collections;

public class Chest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnMouseEnter() {
		Debug.Log("Mouse over.");
	}

	public void OnMouseExit() {
		Debug.Log("Mouse out.");
	}
	
	public void OnMouseUp() {
		Debug.Log("Mouse button relieved.");
	}
}
