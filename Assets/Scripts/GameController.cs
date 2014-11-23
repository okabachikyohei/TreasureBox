using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GUITexture guiGameOver;

	public GUITexture guiGameClear;

	public int clearSnowManPoit = 5;
		

	public enum GameState {
		PLAYING,
		GAMEOVER,
		GAMEOVER_TO_TITLE,
	}

	private GameState state;

	SnowManPoint snowManPoint;

	Timer timer;

	//  ゲームの初期化
	void Start() {

		snowManPoint = GameObject.Find("SnowManPoint").GetComponent<SnowManPoint>();
		timer = GameObject.Find ("Timer").GetComponent<Timer> ();
		state = GameState.PLAYING;
		guiGameOver.enabled = false;
		guiGameClear.enabled = false;
		timer.StartTimer ();
	
	}
	
	void Update () {
		switch (state) {
		case GameState.PLAYING:
			if (timer.GetTimeRemaining() <= 0) { 
				guiGameOver.enabled = true;
			}

			if (snowManPoint.getSnowManPoit() >= clearSnowManPoit) {
				timer.StopTimer();
				timer.ResetTimer();
				guiGameClear.enabled = true;
			}
			break;
		}
	}
}