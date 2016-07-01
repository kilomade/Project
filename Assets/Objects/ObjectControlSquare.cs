using UnityEngine;
using System.Collections;

public class ObjectControlSquare : MonoBehaviour {

    public Rigidbody Contact;

    void Update() {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }

	
}
