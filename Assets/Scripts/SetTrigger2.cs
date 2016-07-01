using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetTrigger2 : MonoBehaviour {
    private int currentCount;
    private bool safe;

    public GameObject Target;
    public GameObject Effect;
    public string Director;
    public string FractionGoal;
    public int TargetGoal;
    public Text Windows;


    //Tag for the CheckScript GameObject Tag
    public string ZoneControllerTag;
    private CheckScript_Special temp;

    // Use this for initialization
    void Start()
    {
        currentCount = 0;
        Windows.text = FractionGoal;

        GameObject CheckObj = GameObject.FindWithTag(ZoneControllerTag);
        if (CheckObj != null)
        {
            temp = CheckObj.GetComponent<CheckScript_Special>();
        }
        if (temp == null)
        {
            Debug.Log("Cannot find" + ZoneControllerTag + " script");
        }
    }

    void OnMouseDown()
    {
        AudioSource sound = GetComponent<AudioSource>();
        if (currentCount == TargetGoal)
        {
            sound.Play();
            temp.GateCount();
            Windows.text = Director;
            Vector3 holder = Target.transform.position;
            Destroy(Target);

        }
    }

    public void IncreaseCount(int x)
    {
        if (x > 0)
        {
            currentCount++;
        }
        else
        {
            currentCount--;
        }

    }
}
