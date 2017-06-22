using UnityEngine;
using System.Collections;

public class animOffsetLooper : MonoBehaviour {

	public float offset;
	private float i = 0f;
	private float incr = 0.1f;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		i += incr;
		if (i >= offset) {
			animation.Play ();
		}else {
			return;
		}
	}

}
