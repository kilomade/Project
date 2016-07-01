using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class PortalObjectControl : MonoBehaviour
{


    void Update()
    {
        transform.Rotate(new Vector3(0.0f, 50, 0.0f) * Time.deltaTime);
    }

    void OnMouseDown()
    {
        Application.LoadLevel("LevelTwo");
    }
}