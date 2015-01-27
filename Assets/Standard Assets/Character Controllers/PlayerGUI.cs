using UnityEngine;
using System.Collections;

public class PlayerGUI : MonoBehaviour {

	public Texture backpack;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		/*Matrix4x4 svMat = GUI.matrix;
		GUI.matrix = Matrix4x4.TRS(new Vector3(0,0,0), Quaternion.identity,new Vector3(Screen.width/1061f,Screen.height/597f,1f));

		GUI.DrawTexture(new Rect(50, 50, 1061/2, 597/2), backpack, ScaleMode.ScaleToFit);

		GUI.matrix = svMat;*/
		GUI.Label(new Rect(10,10, Screen.width/2, Screen.height/2), backpack);
	}
}
