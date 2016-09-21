using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class ObjectControl : MonoBehaviour {

	//Script Master
	public GameObject TaskMaster;

	//Rotates of the squares per frame
	Rigidbody rb;
	public float yaxis = 2f, xaxis = 2f, zaxis = 3f;
	public float speed;
	private bool startup = false;

	//Material for changing color and effects on click
	public Material material1;
	public Material material2;
	public Material[] Materials;
	public float ChangeInterval = 0.33F;
	public Renderer rend;
	bool mat1 = true;
	bool mat2 = false;


	void Start()
	{
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rb = gameObject.GetComponent (typeof(Rigidbody)) as Rigidbody;
		startup = false;

	}

	void FixedUpdate()
	{
		//**************************************************************************************
		if (startup)
		{                       //Activates the rotation of the squares on click
			rb.transform.Rotate(new Vector3(xaxis, yaxis, zaxis) * speed);

			if (Materials.Length == 0)
				return;
			int index = Mathf.FloorToInt (Time.time / ChangeInterval);
			index = index % Materials.Length;

			rend.sharedMaterial = Materials [index];
		}
		else if (!startup)
		{
			rend.material = material1;

		}
	}

	void OnMouseDown()
	{                    //Rotates the squares once they are selected     

		AudioSource sound = GetComponent<AudioSource>();

		if (startup == false)
		{
			startup = true;
			sound.Play();
			TaskMaster.SendMessage("CountEdit", true);
		}
		else {
			startup = false;
			sound.Play();
			TaskMaster.SendMessage("CountEdit", false);
		}
	}

	public void ReetStart(){
		startup = false;
	}



}
