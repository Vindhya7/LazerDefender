using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scorekeeper : MonoBehaviour {

	public static int score=0;
	private Text mytext;

	void Start(){
	
		mytext=GetComponent<Text> ();
		reset ();
	
	}

	public void scoreinc(int point){
		score += point;
		mytext.text = score.ToString();

		if (score == 20000) {
			Debug.Log ("New level");
			LevelManager level = GameObject.Find ("LevelManager").GetComponent<LevelManager>();
			level.LoadLevel ("Win Screen");
		}
	}

	public static void reset(){
		score = 0;
		//mytext.text = score.ToString();
	}
}
