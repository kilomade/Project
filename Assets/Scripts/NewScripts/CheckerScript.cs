using UnityEngine;
using System.Collections;

public class CheckerScript : MonoBehaviour {

	public GameObject TaskMaster;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void OnMouseDown(){
		TaskMaster.SendMessage ("Check", 1);
	}
}
