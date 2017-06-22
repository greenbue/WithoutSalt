using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
	public int saltCost;
	private int health;
	public bool isActivated;
	Controller player;
	public Material[] materials;

	// Use this for initialization
	void Start () {
		saltCost = 1;
		player = (Controller) FindObjectOfType (typeof(Controller));
		renderer.material = materials [isActivated ? 1 : 0];
	}
	
	// Update is called once per frame
	void Update () {
		//renderer.material = isActivated ? activatedMat : normalMat;
		renderer.material = materials [isActivated ? 1 : 0];
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.name == "Player")
		{
			if(!isActivated){
				player.setLastCheckpoint(this);
				isActivated = true;
			}
		}
	}

	public void deactivate(){
		isActivated = false;
	}

	public void spawn(){
		player.useSalt (saltCost);
		//Play anim
	}
}
