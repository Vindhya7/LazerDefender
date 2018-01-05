using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;

	public AudioClip start;
	public AudioClip Game;
	public AudioClip death;


	private AudioSource music;
	
	void Start () {
		if (instance != null && instance != this) {
			Destroy (gameObject);
			print ("Duplicate music player self-destructing!");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
			music = GetComponent<AudioSource> ();
			music.clip = start;
			music.loop = true;
			music.Play ();
		}
		
	}

	void OnLevelWasLoaded(int level){
		music.Stop ();

		if (level == 0) {
			music.clip = start;
		}
		if (level == 1) {
			music.clip = Game;
		}

		if (level == 3) {
			music.clip = death;
		}

		if (level == 2) {
			music.clip = start;
		}

		music.loop = true;
		music.Play ();

	
	}
}
