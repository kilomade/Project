using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class UniversalCheckScript : MonoBehaviour {

    public Text Output;
    public int TargetActive1, TargetActive2, TargetActive3;
    public GameObject SetMaster1, SetMaster2, SetMaster3;
    public GameObject other;
    public GameObject effect;
    public GameObject effectlocation;


    private int attempts;
    private int Active1, Active2, Active3;
    private int Pass;

    
    void start() {
        attempts = 0;
        Active1 = 0;
        Active2 = 0;
        Active3 = 0;
        Pass = 0;
    }

    void OnMouseDown()
    {
        getScore1();
        getScore2();
        getScore3();
        attempt();
    }
    //***********************************************************************************
    private void getScore1()
    {
        if (Active1 == TargetActive1)
        {
            Pass += 1;
            Destroy(SetMaster1);
        }
    }

    private void getScore2()
    {
        if (Active2 == TargetActive2)
        {
            Pass += 1;
            Destroy(SetMaster2);
        }

    }

    private void getScore3()
    {
        if (Active3 == TargetActive3)
        {
            Pass += 1;
            Destroy(SetMaster3);
        }
    } 

    //*************************************************************************************
     public void score1( int temp ) {
        if( temp > 0 ) { Active1 += 1;
             }
            else if( temp < 0) { Active1 -= 1;  }
     }

    public void score2(int temp)
    {
        if (temp > 0)
        {
            Active2 += 1;
        }
        else if (temp < 0) { Active2 -= 1; }
    }

    public void score3(int temp)
    {
        if (temp > 0)
        {
            Active3 += 1;
        }
        else if (temp < 0) { Active3 -= 1; }
    }

    //****************************************************************************
    private void attempt() {
        if( Pass != 3) {
            attempts++;
        }

        if( Pass == 3) {
            Vector3 temp = effectlocation.transform.position;
            Destroy(effectlocation);
            Instantiate(effect, temp, Quaternion.identity);
            Output.text = "Good Work";
            Destroy(other);
        }
        if( attempts == 3) {
            Destroy(SetMaster1);
            Destroy(SetMaster2);
            Destroy(SetMaster3);
            Output.text = "New problem will be generated";
        }
     }

     
   
}
