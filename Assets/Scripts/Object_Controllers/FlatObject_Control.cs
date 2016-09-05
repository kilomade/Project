using UnityEngine;
using System.Collections;

public class FlatObject_Control : MonoBehaviour {

	//Script Master
	public GameObject TaskMaster;
	public string ScriptVerifier;

    private bool startup;
    public GameObject rb;

    //Material for changing color and effects on click
    public GameObject Effect;
    public Material material1;
    public Material material2;
    bool mat1 = true;
    bool mat2 = false;

    void Start()
    {
		rb = GetComponent<Rigidbody>();
        startup = false;
		string pull = TaskMaster.ScriptChecker ();
		bool result = ScriptVerifier.Equals (pull, System.StringComparison.OrdinalIgnoreCase);

		if (result)
			continue;
		else {
			Debug.LogError("Script Verification Fail: Flat Object Controller");
		}
    }

    void OnMouseDown()
    {                    //Changes the color of the tile     

        Renderer rend = GetComponent<Renderer>();       //Sets the material of the object
        AudioSource sound = GetComponent<AudioSource>();
        rend.material = material1;

        if (startup == false)
        {
            startup = true;
            mat1 = false;
            mat2 = true;
            sound.Play();
			TaskMaster.CountEdit (true);
        }
        else
        {
            startup = false;
            mat1 = true;
            mat2 = false;
            sound.Play();
			TaskMaster.CountEdit (false);
        }
    }

    void Update()
    {
        Renderer rend = GetComponent<Renderer>();       //Sets the material of the square
        rend.material = material1;

        if (startup)
        {   //Changes the material of the model             
            rend.material = material2; 
        }
        else if (!startup)
        {
            rend.material = material1;

        }
    }


}
