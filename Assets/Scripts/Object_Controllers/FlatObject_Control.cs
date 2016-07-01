using UnityEngine;
using System.Collections;

public class FlatObject_Control : MonoBehaviour {

    private bool startup;
    public GameObject rb;

    //Material for changing color and effects on click
    public GameObject Effect;
    public Material material1;
    public Material material2;
    bool mat1 = true;
    bool mat2 = false;

    //External Functionality
    public string TargetTag;
    private SetTrigger ScoreTracker;

    void Start()
    {
        GameObject CheckObj = GameObject.FindWithTag(TargetTag);
        if (CheckObj != null)
        {
            ScoreTracker = CheckObj.GetComponent<SetTrigger>();
        }
        if (ScoreTracker == null)
        {
            Debug.Log("Cannot find " + TargetTag + "script");
        }

        startup = false;
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
            ScoreTracker.IncreaseCount(1);
        }
        else
        {
            startup = false;
            mat1 = true;
            mat2 = false;
            sound.Play();
            ScoreTracker.IncreaseCount(-1);
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
