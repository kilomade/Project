using UnityEngine;
using System.Collections;
using System.IO;

public class GameManager : MonoBehaviour {

	public string Username;
	public string First_name;
	public string Last_name;
	public int ID_Code;
	string FileDirectory;

	// Checks for profile of each student inside of SaveFiles. If not present it creates a new subfolder for the student
	void Start () {
		string folderName = @"C:\Users\Christian\Documents\GitHub\Project\Assets\SaveFiles";
		string pathString = System.IO.Path.Combine (folderName, Username);

		if (Directory.Exists (pathString)) {
		} else {
			System.IO.Directory.CreateDirectory (pathString);
		}

		string FileName = Username + ".txt";
		FileDirectory = System.IO.Path.Combine (pathString, FileName);

		if (File.Exists (FileDirectory)) {
		} else {
			System.IO.File.Create (FileDirectory);
			string BaseInfo = "First Name: " + First_name + "\n" + "Last Name: " + Last_name + "\n" + "ID Code: " + ID_Code +
			                  "Date Created: " + System.DateTime.Now;
		}
		Debug.Log ("Profile created: " + pathString + "\n");
		Debug.Log ("Student Name: " + First_name + " " + Last_name);
			
	}

	//Writes all inputs from students to Profile
	public void WriteToProfile( string a ){
		string holder = File.ReadAllText (FileDirectory);
		string Rebuild = holder + a;
		File.WriteAllText (FileDirectory, Rebuild);
	}
}
