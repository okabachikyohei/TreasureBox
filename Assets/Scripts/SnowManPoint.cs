using UnityEngine;
using System.Collections;

public class SnowManPoint : MonoBehaviour {
	
	private int snowManPoint;

	void InitSnowManPoint() {
		this.snowManPoint = 0;
	}

	void AddSnowManPoint(int snowManPoint) {
		this.snowManPoint += snowManPoint;
	}
	
	void Update () {
		guiText.text = "雪だるまの個数：" + this.snowManPoint;	
	}

	public int getSnowManPoit () {
		return this.snowManPoint;
	}
}