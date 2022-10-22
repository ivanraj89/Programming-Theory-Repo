using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildCube2 : BaseMotherCube
{
    public override void MoveCube()
    {
        transform.Translate(0.1f * Time.deltaTime, 0,0); //polymorphism
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCube();
    }

    
}
