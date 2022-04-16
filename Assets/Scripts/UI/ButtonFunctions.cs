using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    public bool isButtonOn = false;
    // Start is called before the first frame update
    void Start()
    {
        isButtonOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PointerDown()
    {
        isButtonOn = true;
    }
    public void PointerUp()
    {
        isButtonOn = false;
    }
}
