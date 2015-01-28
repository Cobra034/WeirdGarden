using UnityEngine;
using System.Collections;

public class ObjectPickup : MonoBehaviour {

	public int objectCnt = 0;
	public GameObject camera;
	public GameObject entrance;
	public GameObject exit;

	/*public AnimationClip cameraRotate;
	public AnimationClip cameraFlip1;
	public AnimationClip cameraFlip2;*/
	
	public bool paintingFound = false;
	public bool gloveFound = false;
	public bool baconFound = false;
	public bool cupFound = false;
	public bool digereedoFound = false;

	public bool redEffect = false;
	public bool cameraFlip = false;

	public float timer = 15.0f;

	void Start(){
		camera = GameObject.FindWithTag("MainCamera");
		entrance = GameObject.FindWithTag("BushEntrance");
		exit = GameObject.FindWithTag("BushExit");
		entrance.gameObject.SetActive(false);

		//animation.AddClip(cameraRotate, "CameraRotate");
	}
	// Update is called once per frame
	void Update () {
		//Debug.Log(objectCnt);
		if(objectCnt == 5)
			exit.gameObject.SetActive(false);
		if(cameraFlip){
			timer -= Time.deltaTime;
			print (timer);
			if(timer <0){
				cameraFlip = false;
				camera.GetComponent<Animation>().Play("CameraFlip2");
			}
		}
	}

	void OnTriggerEnter(Collider other){
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
			Debug.Log("Camera Rotate Triggered");
			camera.GetComponent<Animation>().Play("CameraRotate");
			Destroy(other.gameObject);
		}
		if(other.gameObject.tag == "EntranceTrigger"){
			entrance.gameObject.SetActive(true);
		}
		if(other.gameObject.tag == "RedEffectTrigger"){
			Debug.Log("Red Triggered");
			redEffect = true;
			Destroy(other.gameObject);
		}
		if(other.gameObject.tag == "CameraFlip"){
			Debug.Log("Camera Flip Triggered");
			cameraFlip = true;
			camera.GetComponent<Animation>().Play("CameraFlip1");
			Destroy(other.gameObject);
		}
	}
}
