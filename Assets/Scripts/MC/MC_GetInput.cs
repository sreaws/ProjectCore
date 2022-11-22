using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MC_GetInput : MonoBehaviour
{
    // Start is called before the first frame update
    private float horizontalValue;

    public float GetHorizontalValue 
    {
        get {return horizontalValue;}
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalControl();
    }

    private void HorizontalControl () 
    {
        if(Input.GetMouseButton(0)){
            horizontalValue = Input.GetAxis("Mouse X");
        }
        else {
            horizontalValue = 0;
        }
    }
}
