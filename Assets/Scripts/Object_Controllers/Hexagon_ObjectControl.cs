using UnityEngine;
using System.Collections;

public class Hexagon_ObjectControl : MonoBehaviour
{

    //Rotates of the squares per frame
    public Rigidbody rb;
    public float yaxis = 2f, xaxis = 2f, zaxis = 3f;
    public float speed;
    private bool startup = false;

    //Material for changing color and effects on click
    public Material material1;
    public Material material2;
    bool mat1 = true;
    bool mat2 = false;

    //External Functionality
    public string TargetTag;
    private SetTrigger ScoreTracker;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GameObject CheckObj = GameObject.FindWithTag(TargetTag);
        if (CheckObj != null)
        {
            ScoreTracker = CheckObj.GetComponent<SetTrigger>();
        }
        if (ScoreTracker == null)
        {
            Debug.Log("Cannot find " + TargetTag + "script");
        }
    }

    void Update()
    {
        Renderer rend = GetComponent<Renderer>();       //Sets the material of the square
        rend.material = material1;


        if (startup)
        {                       //Activates the rotation of the squares on click
            rb.transform.Rotate(new Vector3(xaxis, yaxis, zaxis) * speed);
            rend.material = material2;
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
            mat1 = false;
            mat2 = true;
            sound.Play();
            ScoreTracker.IncreaseCount(1);
        }
        else {
            startup = false;
            mat1 = true;
            mat2 = false;
            sound.Play();
            ScoreTracker.IncreaseCount(-1);
        }
    }


}
