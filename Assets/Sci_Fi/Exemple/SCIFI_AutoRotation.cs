using UnityEngine;
using System.Collections;

public class SCIFI_AutoRotation : MonoBehaviour {

	public Vector3 x=new Vector3(0,0,1);
	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (x);
	}
}
