using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckScript : MonoBehaviour {
    private int GateTrigger;
    public int Goal;
    public GameObject Target;
    public GameObject Effect;

    //Text windows for each puzzle
    public Text a1, a2, a3, a4, a5, a6;

    void Start() {
        GateTrigger = 0;
    }

    void Update() {
        if( GateTrigger == Goal) {
            Vector3 loca = Target.transform.position;
            Destroy(Target);
            Instantiate(Effect, loca, Quaternion.identity);
            a1.text = "Gate Unlocked";
            a2.text = "Gate Unlocked";
            a3.text = "Gate Unlocked";
            a4.text = "Gate Unlocked";
            a5.text = "Gate Unlocked";
            a6.text = "Gate Unlocked";
        }
    }
    public void GateCount() {
        GateTrigger++;
    }

	
}
