using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	public bool MovX=true;
	public bool MovY=false;
	public bool MovZ=false;
	float pos;
	float pos2;
	float fpos;
	float mpos;

	// Use this for initialization
	void Start () 
	{
		pos = this.transform.localPosition.x;
		pos2 = this.transform.localPosition.x-2.0f;
		fpos = pos;
		//new Vector3(this.transform.position.x-2.0f,this.transform.position.y,this.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () 
	{
		mpos=Mathf.MoveTowards(mpos,fpos,Time.deltaTime*8);
		if (MovX) this.transform.localPosition = new Vector3 (mpos, this.transform.localPosition.y, this.transform.localPosition.z);
		if (MovY) this.transform.localPosition = new Vector3 (this.transform.localPosition.x, mpos, this.transform.localPosition.z);
		if (MovZ) this.transform.localPosition = new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y, mpos);

	}
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.name == "First Person Controller") 
		{
			fpos=pos2;
		}
	}
	void OnTriggerExit(Collider other) {
		Debug.Log ("test");
			fpos=pos;

	}
}
