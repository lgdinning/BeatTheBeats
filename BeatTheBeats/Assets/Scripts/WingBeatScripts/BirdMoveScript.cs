using UnityEngine;

public class BirdMoveScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            myRigidbody.linearVelocity = Vector2.up * 8;
        }
        else 
        {

        }
    }
}
