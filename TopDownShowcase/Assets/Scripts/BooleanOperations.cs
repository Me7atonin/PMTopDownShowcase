using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooleanOperations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool tf = true;
        bool tf2 = false;
        bool tf3 = true;
        if (tf && tf2 || !tf3)
        {
            //do something
        }
        bool cakeMix = true;
        bool eggs = true;
        bool flour = true;
        bool sugar = true;
        bool money = true;
        if (cakeMix || eggs && flour && sugar || money)
        {
            //I get cake
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
