using UnityEngine;
using System.Collections;

public class RandomLight : MonoBehaviour {

	float MemoLight;
	public float Intensity = 0.25f;
	// Use this for initialization
	void Start () {
		MemoLight = this.GetComponent<Light>().intensity;
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Light>().intensity = Random.Range (MemoLight - Intensity, MemoLight + Intensity);
	}
}
