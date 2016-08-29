using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class WindowScript : MonoBehaviour {
	public int Value;
	public Text Main;
	public Text Response;
	int InputCount;
	string Answer;	  //Expected response
	string Input;   //User input 
	string[] QuestionSet = new string[20];
	string[] AnswerSet = new string[20];


	// Use this for initialization
	void Start () {
		InputCount = 0;

		//Questions
		QuestionSet[0] = "Gabriela ate 5 slices of pie. Danial ate 2 slices. \n If there were 10 slices of pie, what fraction of pie did Danial eat?";
		QuestionSet[1] = "Gabriela ate 5 slices of pie. Danial ate 2 slices. \n If there were 10 slices of pie, what fraction of pie did Gabriela eat?";
		QuestionSet[2] = "Erin baked 32 cookies. She wants to bring 3/8 of those cookies  to her \n Girl Scout meeting. How many cookies will she bring to girl scouts?";
		QuestionSet [3] = "Greg and Peter bought a large pizza to share.\n Greg ate 5/8 of the pizza.\n What fraction of the pizza was left for Peter?";
		QuestionSet [4] = "Monica and Ryan shared 18 cookies.\nMonica ate 1/6 of the cookies.\nRyan ate 1/3 of the cookies. How many cookies did Ryan eat?";
		QuestionSet [5] = "There are usually 30 students in Mrs. Wagner's 3rd grade class.\n1/5 of the students are absent.\nHow many students were in class?\n";
		QuestionSet [6] = "40 students joined the soccer club.\n5/8 of the students were boys.\nHow many girls joined the soccer club?\n";
		QuestionSet [7] = "Kelly had $24.\nShe spent 5/6 of her money on a book.\nHow much money did Kelly have left?";

		//Answers
		AnswerSet[0] = "5/10";
		AnswerSet [1] = "2/10";
		AnswerSet [2] = "12";
		AnswerSet [3] = "3/8";
		AnswerSet [4] = "6";
		AnswerSet [5] = "24";
		AnswerSet [6] = "3/8";
		AnswerSet [7] = "4";


		Main.text = QuestionSet [Value];
	}

	//**************************************************************************************************
	void CheckResponse(string Answer,string Input){
		if( Answer == Input ){
			Main.text = "Correct. Congratulations :-)";
		}

		if( Answer != Input ){
				Response.text = "Try Again. How many base parts can the mysteries be divided into?";
		}

	}
		

	//***************************************************************************************************
	public void Outreach(string Holder){
		Input = Holder;
		CheckResponse (AnswerSet[Value], Holder);
	}


}
