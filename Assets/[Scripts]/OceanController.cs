using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanController1 : MonoBehaviour
{
    public float verticalSpeed; // can be seen in Unity object inspector
    public Boundary boundary; 

    // Start is called before the first frame update
    /*void Start()
    {
        
    }*/



    // Fixed timestamp
    void FixedUpdate() // lifecycle method
    {
        Move();
        CheckBounds();
    }

    void Move()
    {
        transform.position -= new Vector3(0.0f, verticalSpeed);
    }
    
    void CheckBounds()
    {
        if( transform.position.y <= boundary.bottom ){
            ResetObject();
        } 
    }

    void ResetObject() 
    {
        transform.position = new Vector2(0.0f, boundary.top);
    }


    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
