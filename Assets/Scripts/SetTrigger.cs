using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetTrigger : MonoBehaviour {

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
    private CheckScript temp;
    
    // Use this for initialization
    void Start () {
        currentCount = 0;
        Windows.text = FractionGoal;

        GameObject CheckObj = GameObject.FindWithTag(ZoneControllerTag);
        if (CheckObj != null)
        {
            temp = CheckObj.GetComponent<CheckScript>();
        }
        if (temp == null)
        {
            Debug.Log("Cannot find" + ZoneControllerTag +" script");
        }
    }

    void OnMouseDown()
    {
        if (currentCount == TargetGoal)
        {
            temp.GateCount();
            Windows.text = Director;
            Vector3 holder = Target.transform.position;
            Destroy(Target);
            Instantiate(Effect, holder, Quaternion.identity);
          
        }
    }

    public void IncreaseCount( int x) {
        if( x > 0 ) {
            currentCount++;
        } else {
            currentCount--;
        }
        
    }
}
