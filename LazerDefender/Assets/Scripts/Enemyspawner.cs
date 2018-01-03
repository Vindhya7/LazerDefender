using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour {
	public GameObject enemyprefab;
	public float width = 10f;
	public float height=5f;
	private bool movingright = true;
	public float speed=5f;

	private float xmin;
	private float xmax;
	// Use this for initialization
	void Start () {

		float distanceToCamera = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftedge=Camera.main.ViewportToWorldPoint (new Vector3(0,0,distanceToCamera));	
		Vector3 rightedge=Camera.main.ViewportToWorldPoint (new Vector3(1,0,distanceToCamera));   
		xmax = rightedge.x;
		xmin = leftedge.x;
		foreach (Transform child in transform) {
			GameObject enemy=Instantiate (enemyprefab, child.transform.position, Quaternion.identity) as GameObject;
			enemy.transform.parent = child;
		}


	
	}

	public void OnDrawGizmos(){
		Gizmos.DrawWireCube (transform.position,new Vector3(width,height));
	}
	// Update is called once per frame
	void Update () {
		if (movingright) {
			transform.position += new Vector3(speed*Time.deltaTime,0);
		} else {
			transform.position += new Vector3(-speed*Time.deltaTime,0);
		}

		float rightedgeofformation=transform.position.x+(0.5f*width);
		float leftedgeofformation=transform.position.x-(0.5f*width);
		if (leftedgeofformation < xmin) {
			movingright = true;
		}else if(rightedgeofformation > xmax){
			movingright = false;
			
	}
}
}