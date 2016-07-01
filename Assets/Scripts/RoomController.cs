using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RoomController : MonoBehaviour {
	private int RoomTrigger;
	public int Goal;
	public GameObject Target;

	//Text windows for each puzzle
	public Text a1, a2, a3, a4, a5, a6;

	void Start() {
		RoomTrigger = 0;
	}

	void Update() {
		if( RoomTrigger == Goal) {
			Vector3 loca = Target.transform.position;
			Destroy (Target);
			a1.text = "Gate Unlocked";
			a2.text = "Gate Unlocked";
			a3.text = "Gate Unlocked";
			a4.text = "Gate Unlocked";
			a5.text = "Gate Unlocked";
			a6.text = "Gate Unlocked";
		}
	}
	public void GateCount() {
		RoomTrigger++;
	}

}
