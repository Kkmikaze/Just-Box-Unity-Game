using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // forwardForce for constant force to Vertical
    public float forwardForce = 2000f;

    // forwardForce for constant force to Horizontal
    public float sideawayForce = 500f;
    void Update()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideawayForce * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sideawayForce * Time.deltaTime, 0, 0);
        }
    }
}