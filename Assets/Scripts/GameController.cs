using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GUITexture gameOver;

	public enum GameState {
		PLAYING,
		GAMEOVER,
		GAMEOVER_TO_TITLE,
	}

	private GameState state;

	private GameObject snowManPoint;

	private Timer timer;

	//  ゲームの初期化
	void Start() {

		snowManPoint = GameObject.Find("SnowManPoint");
		timer = GameObject.Find ("Timer").GetComponent<Timer> ();
	
	}
	
	void Update () {

	}

}
