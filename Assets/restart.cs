using UnityEngine;
using System.Collections;

public class restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
		animation.Play();
		StartCoroutine(TestCoroutine());
	}

	IEnumerator TestCoroutine(){
		yield return new WaitForSeconds (4);
		Application.LoadLevel("EditedNoExtra");
	}
	// Update is called once per frame
	void Update () {
		
	}
}
