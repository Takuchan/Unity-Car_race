using UnityEngine;
using System.Collections;

public class enemy : MonoBehaviour {

	void Update (){
		transform.Translate (new Vector3(-0.1f,1,9));
		if (transform.position.z < Camera.main.transform.position.z) {
			Destroy (gameObject);
		}
	}

}