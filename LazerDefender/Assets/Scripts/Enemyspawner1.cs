using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner1 : MonoBehaviour {
	public GameObject enemyprefab;
	// Use this for initialization
	void Start () {
		
		foreach (Transform child in transform) {
			GameObject enemy=Instantiate (enemyprefab, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
			enemy.transform.parent = transform;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
