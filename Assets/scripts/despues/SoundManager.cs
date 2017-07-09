
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioSource audioMusicFondo;
	public AudioSource correcta;
	public AudioSource incorrecta;

	void Start () {
		audioMusicFondo.Play();
	}
	

	void Update () {
		
	}

	public void PlaySoundCorrect(){
	
		correcta.Play();
	}
	public void PlaySoundInCorrect(){

		incorrecta.Play();
	}
}
