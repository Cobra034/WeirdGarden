using UnityEngine;
using System.Collections;

public class PlayerGUI : MonoBehaviour {

	public Texture backpack;
	public int objectCnt = 0;
	public GameObject player;
	public GUIStyle ui;
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		objectCnt = player.GetComponent<ObjectPickup>().objectCnt;
	}

	void OnGUI(){
		Matrix4x4 svMat = GUI.matrix;
		GUI.matrix = Matrix4x4.TRS(new Vector3(0,0,0), Quaternion.identity,new Vector3(Screen.width/1061f,Screen.height/597f,1f));

		GUI.DrawTexture(new Rect(1061/2-500, 597/2+125, 175, 175), backpack, ScaleMode.ScaleToFit);
		GUI.Label(new Rect(1061/2-460, 597/2+165, 200, 200), objectCnt+"/5", ui);

		GUI.matrix = svMat;
		//GUI.Label(new Rect(Screen.width/2, Screen.height/2, 100, 100), backpack);
	}
}
