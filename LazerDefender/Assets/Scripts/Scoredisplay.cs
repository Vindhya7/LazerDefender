using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoredisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Text mytext = GetComponent<Text>();
		mytext.text = Scorekeeper.score.ToString ();
		Scorekeeper.reset ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
