using UnityEngine;
using System.Collections;

public class ObjectPickup : MonoBehaviour {

	public int objectCnt = 0;
	
	// Update is called once per frame
	void Update () {
		Debug.Log(objectCnt);
	}

	void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == "Collect"){
			objectCnt++;
			Destroy(other.gameObject);
		}
	}
}
