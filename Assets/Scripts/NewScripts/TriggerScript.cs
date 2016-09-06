using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TriggerScript : MonoBehaviour {

	string Username;

	//currentActive counts the number of active objects
	//safeTrigger works to prevent user from cheating
	private int currentActive;
	private bool safeTrigger;
	public int Goal_Active;


	//questinNumber and answerArray refer to the displayed question
	public int questionNumber;
	public int responseNumber;
	private string[] questionArray = new string[20];
	private string[] responseArray = new string[10];
	public Text Main;
	public Text Secondary;

	//ExtObject is the external game object
	//Effect will be replace objects upon correct submission
	//Interactive object controller
	public GameObject TargetObject;
	public GameObject Effect;
	private Vector3 positionHolder;
	public GameObject[] Path = new GameObject[5];

	//**************************************************************************************************************
	//**************************************************************************************************************
	//**************************************************************************************************************

	// Use this for initialization
	void Start () {
		currentActive = 0;
		positionHolder = TargetObject.transform.position;

		//Questions if indexes goes beyond 19. Remember to correct the array declaration
		questionArray[0] = "Gabriela ate 3 slices of pie. Danial ate 2 slices. \n If there were 6 slices of pie, what fraction of pie did Danial eat?";
		questionArray[1] = "Gabriela ate 5 slices of pie. Danial ate 2 slices. \n If there were 10 slices of pie, what fraction of pie did Gabriela eat?";
		questionArray[2] = "Erin baked 32 cookies. She wants to bring 3/8 of those cookies  to her \n Girl Scout meeting. How many cookies will she bring to girl scouts?";
		questionArray [3] = "Greg and Peter bought a large pizza to share.\n Greg ate 5/8 of the pizza.\n What fraction of the pizza was left for Peter?";
		questionArray [4] = "Monica and Ryan shared 18 cookies.\nMonica ate 1/6 of the cookies.\nRyan ate 1/3 of the cookies. How many cookies did Ryan eat?";
		questionArray [5] = "There are usually 30 students in Mrs. Wagner's 3rd grade class.\n6 of the students are absent.\nWhat fraction of students were in class were in class?\n";
		questionArray [6] = "40 students joined the soccer club.\n5/8 of the students were boys.\nHow many girls joined the soccer club?\n";
		questionArray [7] = "Kelly had $24.\nShe spent 5/6 of her money on a book.\nHow much money did Kelly have left?";

		//Response to user input
		responseArray[0] = " Great Job " + Username;
		responseArray [1] = " Way to go " + Username;
		responseArray [2] = " Let's try that again " + Username;
		responseArray [3] = " You're fabolous " + Username;
		Main.text = questionArray [questionNumber];
	}


	//Verifies correct script
	public string ScriptChecker(){
		string resp = "TriggerScript";
		return resp;
	}

	//Checks for correct input and replaces the objects with effects
	public void Check() {
		if (currentActive == Goal_Active) {
			Destroy (TargetObject);
			for (int x = 0; x < 5; x++)
				Destroy (Path [x]);
			Instantiate (Effect, positionHolder, Quaternion.identity);
			Main.text = responseArray [responseNumber];
			Secondary.text = responseArray [responseNumber];
		} else {
			Secondary.text = responseArray [2];
		}
	}


	//Allows external objects to increment activeCount
	public void CountEdit(bool resp){
		if (resp)
			currentActive++;
		if (!resp)
			currentActive--;
	}


}
