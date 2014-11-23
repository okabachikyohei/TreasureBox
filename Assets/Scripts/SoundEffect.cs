using UnityEngine;
using System.Collections;

public class SoundEffect : MonoBehaviour {

	public AudioClip seClear;
	public AudioClip seNotClear;
	public AudioClip seScream;
	public AudioClip seGet;
	public AudioClip seBlank;
	public AudioClip seOpen;

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
	public void PlayBlank() {
		audio.PlayOneShot(seBlank);
	}
	public void PlayOpen() {
		audio.PlayOneShot(seOpen);
	}
}
