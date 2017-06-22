using UnityEngine;
using System.Collections;

public class Popup : MonoBehaviour {
	Controller target;
	Quaternion standing;
	// Use this for initialization
	void Start () {
		target = (Controller) FindObjectOfType (typeof(Controller));
		standing = new Quaternion();
		standing.y = transform.rotation.y;
		standing.z = transform.rotation.z;
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(transform.position, target.transform.position) < 4) {
			standing = Quaternion.AngleAxis(0, Vector3.left);
		} else {
			standing = Quaternion.AngleAxis(-90, Vector3.left);
		}

		transform.rotation = Quaternion.Slerp(transform.rotation, standing, Mathf.Sqrt(Time.deltaTime)*0.9f);
	}
}
