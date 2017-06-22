using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public class PatrolV2 : MonoBehaviour {
	public float movementSpeed = 2;
	public bool pausePatrol = false;
	public bool followHero = false;
	public bool switchDir = false;
	public float moveLimit = 15;
	private float origPos;
	// Use this for initialization
	
	void Start () {
		origPos = transform.position.x;
	}
	
	void OnCollisionEnter (Collision col)
	{
		if (col.collider.tag.Equals ("Enemy")) {
			switchDir = !switchDir;
			transform.Rotate(new Vector3(0,180, 0));
		}
	}
	
	// Update is called once per frame
	void Update () {
		

			transform.Translate (Vector3.right * movementSpeed * Time.deltaTime);
			if(transform.position.x > origPos+moveLimit){
				transform.Rotate(new Vector3(0,180, 0));
				//transform.Rotate(new Vector3(0,180,0));
				switchDir = true;
			}

			if(transform.position.x < origPos-moveLimit){
				switchDir = false;
				transform.Rotate(new Vector3(0,180,0));
			}
		
		
		
	}
	
}