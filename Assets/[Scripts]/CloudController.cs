using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{
    public float verticalSpeed; // can be seen in Unity object inspector
    public float horizontalSpeed; // can be seen in Unity object inspector
    public Boundary boundary; 
    public Boundary speeds; 

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
        transform.position -= new Vector3(horizontalSpeed, verticalSpeed);
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
        float randomYPosition = Random.Range(boundary.top, boundary.top + 3);
        transform.position = new Vector2(randomXPosition, randomYPosition);
        verticalSpeed = Random.Range(speeds.bottom, speeds.top);
        horizontalSpeed = Random.Range(speeds.left, speeds.right);
    }

}
