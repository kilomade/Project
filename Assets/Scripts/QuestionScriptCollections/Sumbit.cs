using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Sumbit : MonoBehaviour {
	string Response;
	public InputField mainInputField;
	public GameObject TextHolder;

	void Start(){
			mainInputField.onValueChanged.AddListener (delegate { ValueChangeCheck(); });
			
		}


	public void ValueChangeCheck( ){
		Response = mainInputField.text;
	}

	void onClick(){
		TextHolder.SendMessage ("Outreach", Response);
	}
}
