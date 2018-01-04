using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybehav : MonoBehaviour {
	
	public float health=150f;
	public GameObject projectile;
	public float projectilespeed=5f;
	public float shotspersec=0.5f;

	public int scorevalue=150;

	private Scorekeeper scorekeeper;

	void Start(){
		scorekeeper=GameObject.Find ("Score").GetComponent<Scorekeeper> ();
	}


	void Update () {
		float prob = Time.deltaTime * shotspersec;

		if (Random.value < prob) {
			Fire ();
		}
	}
    void Fire(){
		Vector3 startpos = transform.position + new Vector3 (0,-1,0);
		GameObject missile=Instantiate (projectile, startpos , Quaternion.identity) as GameObject;
		missile.GetComponent<Rigidbody2D>().velocity = new Vector3 (0,-projectilespeed,0);
	}
	void OnTriggerEnter2D(Collider2D col){
		projectile missile = col.gameObject.GetComponent<projectile> ();

		if (missile) {
			health -= missile.getdamage ();
			missile.hit ();
			if (health <= 0) {
				Destroy (gameObject);
				scorekeeper.scoreinc (scorevalue);
			}

		}
	}
}
