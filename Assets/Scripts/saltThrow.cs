using UnityEngine;
using System.Collections;

public class saltThrow : MonoBehaviour {
	public Object toCreate;

	Vector3 origin;
	Vector3 target;
	Controller player;

	// Use this for initialization
	void Start () {
		player = (Controller) FindObjectOfType (typeof(Controller));
		target = player.mouseLocation;
		origin = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3.Lerp (origin, target, Time.frameCount/100.0f);
		transform.rigidbody.AddForce((origin - target)* -10);
		//transform.position = target;

	}

	void FixedUpdate(){
		//rigidbody.AddForce (Vector3.Normalize (origin + target));
		//transform.position = target;
		//rigidbody.rotation = Quaternion.FromToRotation (origin, target);
	}

	void OnCollisionEnter(Collision collision) {
		ContactPoint contact = collision.contacts[0];
		if (contact.otherCollider.tag == "Enemy") {
						Patrol a = contact.otherCollider.GetComponent<Patrol> ();
						a.kill ();
				} else {
						Quaternion rot = Quaternion.FromToRotation (Vector3.up, contact.normal);
						Vector3 pos = contact.point;
						Instantiate (toCreate, pos, rot);
						Destroy (gameObject);
				}
	}
}
