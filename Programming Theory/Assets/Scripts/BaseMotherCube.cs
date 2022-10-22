using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMotherCube : MonoBehaviour
{
    [SerializeField] private float directionSpeed = 0.1f; //Encapsulation 
    [SerializeField] private float moveSpeed; //Encapsulation 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCube();
    }

    public virtual void MoveCube() // abstraction 
    {
        moveSpeed = directionSpeed * Time.deltaTime;
        transform.Translate(0, moveSpeed, 0);
    }

}
