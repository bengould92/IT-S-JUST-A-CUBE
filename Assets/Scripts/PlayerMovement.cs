using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a referece to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
  
    // We marked this as "Fixed"Update because we are using to adjust physics.
  void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a forward force of 2000 on z-axis. Time.deltaTime to negate frame rate performance.

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
