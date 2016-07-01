using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class LoadLevel : MonoBehaviour {

    void OnMouseDown() {
        Application.LoadLevel("LevelTwo");
    }
}
