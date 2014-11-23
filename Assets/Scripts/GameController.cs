using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GUITexture guiGameOver;

	public enum GameState {
		PLAYING,
		GAMEOVER,
		GAMEOVER_TO_TITLE,
	}

	private GameState state;

	private GameObject snowManPoint;

	Timer timer;

	//  ゲームの初期化
	void Start() {

		snowManPoint = GameObject.Find("SnowManPoint");
		timer = GameObject.Find ("Timer").GetComponent<Timer> ();
		state = GameState.PLAYING;
		guiGameOver.enabled = false;
		timer.StartTimer ();
	
	}
	
	void Update () {
		switch (state) {
		case GameState.PLAYING:
			if (timer.GetTimeRemaining() <= 0) { 
				guiGameOver.enabled = true;
			}
			break;
		}
	}
}