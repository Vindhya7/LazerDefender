using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemybehav : MonoBehaviour {
	
	public float health=150f;

	void OnTriggerEnter2D(Collider2D col){
		projectile missile = col.gameObject.GetComponent<projectile> ();

		if (missile) {
			health -= missile.getdamage ();
			missile.hit ();
			if (health <= 0) {
				Destroy (gameObject);
			}

		}
	}
}
