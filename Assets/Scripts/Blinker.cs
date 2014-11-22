using UnityEngine;
using System.Collections;

public class Blinker : MonoBehaviour {

	// Use this for initialization
	private float nextTime;
	public float interval = 0.5f;    // 点滅周期
	
	// Use this for initialization
	void Start() {
		nextTime = Time.time;
	}
	
	// Update is called once per frame
	void Update() {
		if ( Time.time > nextTime ) {
			renderer.enabled = !renderer.enabled;
			
			nextTime += interval;
		}
	}
}
