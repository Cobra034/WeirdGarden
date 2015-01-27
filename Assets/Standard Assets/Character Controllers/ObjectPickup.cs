using UnityEngine;
using System.Collections;

public class ObjectPickup : MonoBehaviour {

	public int objectCnt = 0;
	public GameObject camera;

	public bool paintingFound = false;
	public bool gloveFound = false;
	public bool baconFound = false;
	public bool cupFound = false;
	public bool digereedoFound = false;

	void Start(){
		camera = GameObject.FindWithTag("MainCamera");
	}
	// Update is called once per frame
	void Update () {
		//Debug.Log(objectCnt);
	}

	void OnTriggerEnter(Collider other){
		/*if(other.gameObject.tag == "Collect"){
			objectCnt++;
			Debug.Log(objectCnt);
			Destroy(other.gameObject);
		}*/
		if(other.gameObject.tag == "Painting"){
			objectCnt++;
			paintingFound = true;
			Debug.Log(objectCnt);
			Destroy(other.gameObject);
		}
		if(other.gameObject.tag == "Glove"){
			objectCnt++;
			gloveFound = true;
			Debug.Log(objectCnt);
			Destroy(other.gameObject);
		}
		if(other.gameObject.tag == "Bacon"){
			objectCnt++;
			baconFound = true;
			Debug.Log(objectCnt);
			Destroy(other.gameObject);
		}
		if(other.gameObject.tag == "Cup"){
			objectCnt++;
			cupFound = true;
			Debug.Log(objectCnt);
			Destroy(other.gameObject);
		}
		if(other.gameObject.tag == "Digereedo"){
			objectCnt++;
			digereedoFound = true;
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
