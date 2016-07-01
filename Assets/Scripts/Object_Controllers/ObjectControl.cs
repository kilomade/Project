using UnityEngine;
using System.Collections;

public class ObjectControl : MonoBehaviour {

    public GameObject TopTier;
    public Rigidbody rb;
    public float yaxis = 2f, xaxis = 2f, zaxis = 3f;       //Rotates of the squares per fram
    public float speed;
    private bool startup = false;
   
    public Material material1;                              //Material for changing color and effects on click 
    public Material material2;
    bool mat1 = true;
    bool mat2 = false;
    //public GameObject effects;


    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        Renderer rend = GetComponent<Renderer>();       //Sets the material of the square
        rend.material = material1;


        if (startup) {                       //Activates the rotation of the squares on click
            rb.transform.Rotate(new Vector3(xaxis, yaxis, zaxis) * speed);
            rend.material = material2;
        } else if ( !startup ) {
            rend.material = material1;
       
        }
    }

    void OnMouseDown() {                    //Rotates the squares once they are selected     

        AudioSource sound = GetComponent<AudioSource>();

        if (startup == false)
        {
            startup = true;
            mat1 = false;
            mat2 = true;
            sound.Play();
        } else {
            startup = false;
            mat1 = true;
            mat2 = false;
            sound.Play();
        }         
    }
   

}
