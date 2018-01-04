using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scorekeeper : MonoBehaviour {

	public int score=0;
	private Text mytext;

	void Start(){
	
		mytext=GetComponent<Text> ();
		reset ();
	
	}

	public void scoreinc(int point){
		score += point;
		mytext.text = score.ToString();
	}

	public void reset(){
		score = 0;
		mytext.text = score.ToString();
	}
}
