using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetTrigger_Room : MonoBehaviour {
	private int currentCount;
	private bool safe;

	public GameObject Target, Target1;
	public GameObject Effect;
	public string Director;
	public string FractionGoal;
	public int TargetGoal;
	public Text Windows;


	//Tag for the CheckScript GameObject Tag
	public string RoomControllerTag;
	private RoomController temp;
	// Use this for initialization
	void Start () {
		currentCount = 0;
		Windows.text = FractionGoal;

		GameObject CheckObj = GameObject.FindWithTag(RoomControllerTag);
		if (CheckObj != null)
		{
			temp = CheckObj.GetComponent<RoomController>();
		}
		if (temp == null)
		{
			Debug.Log("Cannot find" + RoomControllerTag +" script");
		}
	}

	void OnMouseDown()
	{
		if (currentCount == TargetGoal)
		{
			
			Destroy(Target);
			Destroy (Target1);

		}
	}

	public void IncreaseCount( int x) {
		if( x > 0 ) {
			currentCount++;
		} else {
			currentCount--;
		}

	}
}
