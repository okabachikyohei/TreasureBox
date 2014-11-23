using UnityEngine;
using System.Collections;

public class TreasureBox : MonoBehaviour {

	private Animator anim;

	private GameObject unitychan;
	private GameObject snowman;
	private GameObject scythe;
	private GameObject snowManPoint;

	public int score = 1;

//	public AnimationClip clip;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.enabled = false;
		unitychan = GameObject.FindGameObjectWithTag ("Player");
		snowManPoint = GameObject.Find ("SnowManPoint");

		foreach (Transform child in transform){
			if(child.tag == "Snowman"){
				snowman = child.gameObject;
				snowman.renderer.enabled = false;
			} else if(child.tag == "scythe"){
				scythe = child.gameObject;
				scythe.renderer.enabled = false;
			} 
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

//	public void OpenBoxAmitaion() {
//		Debug.Log ("OpenBoxAmitaion called!!");
//		anim.SetBool ("OpenBox", true);
//	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.CompareTag ("Player")) {
			Debug.Log("OnTriggerEnter called!!");
			anim.enabled = true;
			anim.SetBool ("OpenBox", true);
			//unitychan.SendMessage ("BoxClicked");
			showItem();

			if (snowman.renderer.enabled) {
				snowManPoint.SendMessage("AddSnowManPoint" , score);
			}

			Destroy(gameObject, 3f);
		}
	}

	private void showItem() {
		int randomNum = Random.Range (0, 100);
		Debug.Log ("random num = " + randomNum);

		if (randomNum >= 0 && randomNum < 10) {
			scythe.renderer.enabled = true;	
		} else if (randomNum >= 11 && randomNum < 60) {
			snowman.renderer.enabled = true;	
		} 
	}

//	void OnMouseDown() {
//		Debug.Log ("OnMouseDown called!!");
//		anim.SetBool ("OpenBox", true);
//		unitychan.SendMessage ("BoxClicked");
//	}
}
