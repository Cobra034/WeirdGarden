using UnityEngine;
using System.Collections;

public class ObjectPickup : MonoBehaviour {

	public int objectCnt = 0;
	public GameObject camera;

	void Start(){
		camera = GameObject.FindWithTag("MainCamera");
	}
	// Update is called once per frame
	void Update () {
		//Debug.Log(objectCnt);
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Collect"){
			objectCnt++;
			Debug.Log(objectCnt);
			Destroy(other.gameObject);
		}
		if(other.gameObject.tag == "CameraRotate"){
			Debug.Log("Triggered");
			camera.GetComponent<Animation>().Play();
			//Destroy(other.gameObject); //If only want to trigger once, use this line of code
		}
	}
}
