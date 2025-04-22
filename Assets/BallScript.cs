using UnityEngine;

public class BallScript : MonoBehaviour
{
    public int verticalSpeed = -1;
    public int horizontalSpeed = 1;

    public Rigidbody2D rigidBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        rigidBody.linearVelocity = new Vector3(horizontalSpeed, verticalSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
