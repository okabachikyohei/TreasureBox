using UnityEngine;
using System.Collections;

public class SoundEffect : MonoBehaviour {

	public AudioClip seClear;
	public AudioClip seNotClear;
	public AudioClip seScream;
	public AudioClip seGet;
	public AudioClip seAttack;
	public AudioClip seOpen;
	public AudioClip seScoreUp;
	public AudioClip seRemainTimeDown;

	public void PlayClear() {
		audio.PlayOneShot(seClear);
	}
	
	public void PlayNotClear() {
		audio.PlayOneShot(seNotClear);
	}
	public void PlayScream() {
		audio.PlayOneShot(seScream);
	}
	
	public void PlayGet() {
		audio.PlayOneShot(seGet);
	}
	public void PlayAttack() {
		audio.PlayOneShot(seAttack);
	}
	public void PlayOpen() {
		audio.PlayOneShot(seOpen);
	}
	public void PlayScoreUp() {
		audio.PlayOneShot(seScoreUp);
	}
	public void PlayRemainTimeDown() {
		audio.PlayOneShot(seRemainTimeDown);
	}
}
