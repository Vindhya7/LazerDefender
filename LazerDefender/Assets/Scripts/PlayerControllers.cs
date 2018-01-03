﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllers : MonoBehaviour {
	public float speed=15.0f;
	public float padding = 1f;
	float xmin;
	float xmax;
	public GameObject projectile;
	public float projectilespeed=5f;
	public float rate=0.2f;
	// Use this for initialization
	void Start () {

		float dist=transform.position.z-Camera.main.transform.position.z;
		Vector3 leftmost= Camera.main.ViewportToWorldPoint(new Vector3(0,0,dist));
		Vector3 rightmost= Camera.main.ViewportToWorldPoint(new Vector3(1,0,dist));
		xmin = leftmost.x+padding;
		xmax = rightmost.x-padding;
	}

	public void Fire(){
		GameObject beam = Instantiate (projectile, transform.position, Quaternion.identity) as GameObject;
		beam.GetComponent<Rigidbody2D>().velocity = new Vector3 (0,projectilespeed,0);
	
	}
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			InvokeRepeating("Fire",0.000001f,rate);
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			CancelInvoke("Fire");
		}

		if(Input.GetKey(KeyCode.LeftArrow)){

			transform.position += Vector3.left * speed * Time.deltaTime;
		}else if(Input.GetKey(KeyCode.RightArrow)){
			transform.position += Vector3.right * speed * Time.deltaTime;
		}else if(Input.GetKey(KeyCode.UpArrow)){
			transform.position+=new Vector3(0,speed*Time.deltaTime,0);
		}else if(Input.GetKey(KeyCode.DownArrow)){
			transform.position+=new Vector3(0,-speed*Time.deltaTime,0);
		}

		float newx = Mathf.Clamp (transform.position.x,xmin,xmax);
		transform.position = new Vector3 (newx,transform.position.y,transform.position.z);
	}
}

