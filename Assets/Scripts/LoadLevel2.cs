using UnityEngine;
using System.Collections;

public class LoadLevel2 : MonoBehaviour {

    void Update()
    {
        transform.Rotate(new Vector3(0.0f, 50, 0.0f) * Time.deltaTime);
    }

    void OnMouseDown()
    {
        Application.LoadLevel("LevelThree");
    }
}
