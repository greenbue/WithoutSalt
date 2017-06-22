using UnityEngine;
using System.Collections;

public class CloudMove : MonoBehaviour {
	bool bTurn = false;
	Vector3 startPos;
	float speed = 1.0f;
	// Use this for initialization
	void Start () {
		startPos = transform.position;
		speed = Random.Range(0f,2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, startPos) > 40) {
						bTurn = true;
			speed = Random.Range(0f,2.0f);
				}

		if (Vector3.Distance (transform.position, startPos) < 40) {
			bTurn = false;
			speed = Random.Range(0f,2.0f);
				}

		if(bTurn){
			transform.Translate (Vector3.left * speed * Time.deltaTime);
				} else {
			transform.Translate (Vector3.right * speed * Time.deltaTime);
				}
	}
}
