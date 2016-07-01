using UnityEngine;
using System.Collections;

public class Tunnell_Rotator : MonoBehaviour {

    public Rigidbody rb;
    public int yaxis, xaxis, zaxis;       //Rotates of the squares per fram
    public float speed;

                                                         
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.transform.Rotate(new Vector3(xaxis, yaxis, zaxis) * speed);
    }
}
