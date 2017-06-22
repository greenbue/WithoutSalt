using UnityEngine;
using System.Collections;

public class endGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider col){
		print ("GG");
		Application.LoadLevel ("End");
	}

	

	// Update is called once per frame
	void Update () {
	
	}
}
