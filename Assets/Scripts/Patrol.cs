using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

public class Patrol : MonoBehaviour {
	public float movementSpeed = 2;
	public bool pausePatrol = false;
	public bool followHero = false;
	public bool switchDir = false;
	public float moveLimit = 15;
	private float origPos;
	private bool bIsFacingRight = true;
	public bool bIsDead = false;
	// Use this for initialization
	
	void Start () {
		origPos = transform.position.x;
	}
	
	void OnCollisionEnter (Collision col)
	{
		if (col.collider.tag.Equals ("Enemy")) {
			switchDir = !switchDir;
			flipDir ();
		}
	}

	void flipDir(){
		bIsFacingRight = !bIsFacingRight;
		Vector3 s = transform.localScale;
		s.x *= -1;
		transform.localScale = s;
	}

	public void kill(){
		bIsDead = true;
		rigidbody.useGravity = true;
		rigidbody.constraints = RigidbodyConstraints.None;
		Color color = gameObject.renderer.material.color;
		gameObject.renderer.material.color = new Color(color.r*0.8f, color.g*0.8f, color.b*0.8f);
	}
	
	// Update is called once per frame
	void Update () {

		if (bIsDead) {
				rigidbody.AddExplosionForce (3f, transform.position + Vector3.up, 4f);
				return;
		}

		if (switchDir == false) {
			transform.Translate (Vector3.right * movementSpeed * Time.deltaTime);
			//move++;
			if(transform.position.x >= origPos+moveLimit){
				switchDir = true;
				flipDir ();
			}
			
		} else {
			transform.Translate (Vector3.left * movementSpeed * Time.deltaTime);
			//move--;
			if(transform.position.x <= origPos-moveLimit){
				switchDir = false;
				flipDir ();
			}
		}
		
		
	}
	
}