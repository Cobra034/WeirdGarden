using UnityEngine;
using System.Collections;

public class PlayerGUI : MonoBehaviour {

	public Texture backpack;
	public Texture backpackInventoryBar;
	public Texture backpackBackground;

	public Texture monaLisa;
	public Texture monaLisaBlurred;
	public Texture glove;
	public Texture gloveBlurred;
	public Texture bacon;
	public Texture baconBlurred;
	public Texture cup;
	public Texture cupBlurred;
	public Texture digereedo;
	public Texture digereedoBlurred;

	public bool inventoryOpen = false;

	public bool paintingFound;
	public bool gloveFound;
	public bool baconFound;
	public bool cupFound;
	public bool digereedoFound;

	public bool redEffect = false;
	public bool redScreen = false;

	public int objectCnt;
	public float timer = 30.0f;

	public GameObject player;
	public GameObject redOverlay;

	public GUIStyle ui;
	
	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		redOverlay = GameObject.FindWithTag("RedOverlay");
		redOverlay.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		objectCnt = player.GetComponent<ObjectPickup>().objectCnt;
		paintingFound = player.GetComponent<ObjectPickup>().paintingFound;
		gloveFound = player.GetComponent<ObjectPickup>().gloveFound;
		baconFound = player.GetComponent<ObjectPickup>().baconFound;
		cupFound = player.GetComponent<ObjectPickup>().cupFound;
		digereedoFound = player.GetComponent<ObjectPickup>().digereedoFound;

		redEffect = player.GetComponent<ObjectPickup>().redEffect;

		if(Input.GetKeyDown(KeyCode.Tab)){
			print ("Key pressed");
			if (!inventoryOpen)
				inventoryOpen = true;
			else
				inventoryOpen = false;
		}
		if(redEffect){
			redOverlay.gameObject.SetActive(true);
			timer -= Time.deltaTime;
			print (timer);
			if(timer <0){
				redEffect = false;
				player.GetComponent<ObjectPickup>().redEffect = false;
				redOverlay.gameObject.SetActive(false);
				timer = 30.0;
			}
		}
	}

	void OnGUI(){
		Matrix4x4 svMat = GUI.matrix;
		GUI.matrix = Matrix4x4.TRS(new Vector3(0,0,0), Quaternion.identity,new Vector3(Screen.width/1061f,Screen.height/597f,1f));

		GUI.DrawTexture(new Rect(1061/2-820, 597/2+130, 800,144), backpackBackground, ScaleMode.ScaleToFit);
		GUI.DrawTexture(new Rect(1061/2-500, 597/2+125, 150, 150), backpack, ScaleMode.ScaleToFit);
		GUI.Label(new Rect(1061/2-465, 597/2+160, 200, 200), objectCnt+"/5", ui);

		if(inventoryOpen){
			GUI.DrawTexture(new Rect(1061/2-335, 597/2+181, 500,100),backpackInventoryBar, ScaleMode.ScaleToFit);
			GUI.DrawTexture(new Rect(1061/2-335, 597/2+180, 100,100), monaLisaBlurred, ScaleMode.ScaleToFit);
			GUI.DrawTexture(new Rect(1061/2-250, 597/2+180, 100,100), gloveBlurred, ScaleMode.ScaleToFit);
			GUI.DrawTexture(new Rect(1061/2-160, 597/2+180, 100,100), baconBlurred, ScaleMode.ScaleToFit);
			GUI.DrawTexture(new Rect(1061/2-70, 597/2+180, 100,100), cupBlurred, ScaleMode.ScaleToFit);
			GUI.DrawTexture(new Rect(1061/2+30, 597/2+180, 100,100), digereedoBlurred, ScaleMode.ScaleToFit);
			if(paintingFound){
				GUI.DrawTexture(new Rect(1061/2-335, 597/2+180, 100,100), monaLisa, ScaleMode.ScaleToFit);
			}
			if(gloveFound){
				GUI.DrawTexture(new Rect(1061/2-250, 597/2+180, 100,100), glove, ScaleMode.ScaleToFit);
			}
			if(baconFound){
				GUI.DrawTexture(new Rect(1061/2-160, 597/2+180, 100,100), bacon, ScaleMode.ScaleToFit);
			}
			if(cupFound){
				GUI.DrawTexture(new Rect(1061/2-70, 597/2+180, 100,100), cup, ScaleMode.ScaleToFit);
			}
			if(digereedoFound){
				GUI.DrawTexture(new Rect(1061/2+30, 597/2+180, 100,100), digereedo, ScaleMode.ScaleToFit);
			}
		}
		GUI.matrix = svMat;
	}
}
