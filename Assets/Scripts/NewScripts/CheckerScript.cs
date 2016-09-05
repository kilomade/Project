using UnityEngine;
using System.Collections;

public class CheckerScript : MonoBehaviour {

	public GameObject TaskMaster;
	public string ScriptVerifier;
	private bool result;

	void Start(){
		string pull = TaskMaster.ScriptChecker ();
		result = ScriptVerifier.Equals (pull, System.StringComparison.OrdinalIgnoreCase);
	}

	void OnMouseDown(){
		
		if (result)
			TaskMaster.Check ();
	}
}
