using UnityEngine;
using System.Collections;

public class BlockMove : MonoBehaviour {

	public float movementSpeed = 2;
	public bool switchDir = false;
	private int move = 0; 
	public float moveLimit = 15;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (switchDir == false) {
			transform.Translate (Vector3.right * movementSpeed * Time.deltaTime);
			//move++;
			if(move >= moveLimit){
				switchDir = true;
			}
			move++;
			
		} else {
			transform.Translate (Vector3.left * movementSpeed * Time.deltaTime);
			//move--;

			if(move < -moveLimit){
				switchDir = false;
			}
			move--;
		}

	}
}
