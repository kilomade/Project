using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CheckScript_Special : MonoBehaviour {
    public int GateTrigger;
    public int Goal;
    public GameObject Effect;
    public string message;

    //Array and names of external elements
    private GameObject[] Array;
    private Vector3[] holder;
    public GameObject Target, Target1, Target2, Target3, Target4, Target5;

    void Start()
    {
        GateTrigger = 0;
        Array[0] = Target;
        Array[1] = Target1;
        Array[2] = Target2;
        Array[3] = Target3;
        Array[4] = Target4;
        Array[5] = Target5;
        holder[0] = Target.transform.position;
        holder[1] = Target1.transform.position;
        holder[2] = Target2.transform.position;
        holder[3] = Target3.transform.position;
        holder[4] = Target4.transform.position;
        holder[5] = Target5.transform.position;
    }

    void LateUpdate()
    {
        if (GateTrigger == Goal)
        {
            for (int x = 0; x < Goal; x++)
            {
                Destroy(Array[x]);

            }
        }
    }

    public void GateCount()
    {
        GateTrigger++;
    }
}
