﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {
	public float damage=100f;

	public float getdamage(){
		return damage;
	}

	public void hit(){
		Destroy (gameObject);
	}


}
