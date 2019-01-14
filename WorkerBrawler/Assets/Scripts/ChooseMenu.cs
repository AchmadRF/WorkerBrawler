using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChooseMenu : MonoBehaviour {

    public GameObject[] btn;
    public int val,batasAtas,BatasBawah;
    int plus;
    
    public bool change = false;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetAxis("Vertical") >= 0)
        {
            val += plus;
            change = true;
        }
        if (Input.GetAxis("Vertical") <= 0)
        {
            val += -plus;
            change = true;
        }if(Input.GetAxis("Vertical") == 0)
        {
            change = false;
        }

        if (change == true)
        {
            plus = 0;
        }
        else
        {
            plus = 1;
        }

        if(val > batasAtas)
        {
            val = batasAtas;
        }
        if (val < BatasBawah)
        {
            val = BatasBawah;
        }
    }
}
