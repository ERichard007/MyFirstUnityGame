using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;

    void Start()
    {
        gameObject.name = "Bird Man III"; 
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.linearVelocity = Vector2.up * 8;
        }
    }
}
