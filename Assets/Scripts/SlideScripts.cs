using UnityEngine;
using System.Collections;

public class SlideScripts : MonoBehaviour {
	//List of gameObjects required
	public GameObject MovingObject;
	public Vector3 NewPosition;
	public bool X;
	public bool Y;
	public bool Z;
	public float ChangeInterval;

	// Use this for initialization
	void Start () {
		Vector3 OriginPos = MovingObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseDown(){
		float xholder = MovingObject.transform.position.x;
		float yholder = MovingObject.transform.position.y;
		float zholder = MovingObject.transform.position.z;

		if (X) {
			while (MovingObject.transform.position != NewPosition) {				
				MovingObject.transform.position = new Vector3 (xholder - ChangeInterval, yholder, zholder);
			}
		};

		if (Y) {
			while (MovingObject.transform.position != NewPosition) {				
				MovingObject.transform.position = new Vector3 (xholder, yholder - ChangeInterval, zholder);
			}
		};

		if (Z) {
			while (MovingObject.transform.position != NewPosition) {				
				MovingObject.transform.position = new Vector3 (xholder , yholder, zholder - ChangeInterval);
			}
		};


	}
}
