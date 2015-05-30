using UnityEngine;
using System.Collections;

public class Playerscript : MonoBehaviour {

	void Start () {

	}

	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.position += this.transform.right * 0.05f;
		}
		else if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.position += this.transform.forward * 0.05f;
		}
		if(Input.GetKey(KeyCode.Space)){
		transform.Translate (0, -0.05f, 0);
		}
	}
}
