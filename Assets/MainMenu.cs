using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public Texture title, play, quit;
	bool bPlay, bQuit;
	Controller player;

	// Use this for initialization
	void Start () {
		player = (Controller) FindObjectOfType (typeof(Controller));
		player.bCanControl = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (bPlay) {
			player.gravity = 20f;
			player.bCanControl = true;

			GameObject a = GameObject.FindGameObjectWithTag("MainCamera");
			a.GetComponent<Camera>().enabled = true;
			this.gameObject.SetActive(false);

		}

		if (bQuit) {
			Application.Quit();
		}
	}

	void OnGUI() {
		Rect r = new Rect (((Screen.width / 2.0f) - title.width /2.0f ), ((Screen.height / 4.0f) - title.height/3.0f), title.width, title.height);
		Rect r1 = new Rect (((Screen.width / 2.0f) - title.width /2.0f ), ((Screen.height / 4.0f)*2 - title.height/3.0f), title.width, title.height);
		Rect r2 = new Rect (((Screen.width / 2.0f) - title.width /2.0f ), ((Screen.height / 4.0f)*3 - title.height/3.0f), title.width, title.height);
		GUI.DrawTexture (r, title);
		bPlay = GUI.Button (r1, play);
		bQuit = GUI.Button (r2, quit);
	}
}
