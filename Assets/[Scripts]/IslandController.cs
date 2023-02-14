using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandController : MonoBehaviour
{
    public float verticalSpeed; // can be seen in Unity object inspector
    public Boundary boundary; 

    void Start(){
        ResetObject();
    }
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
        float randomXPosition = Random.Range(boundary.left, boundary.right);
        transform.position = new Vector2(randomXPosition, boundary.top);
    }

}
