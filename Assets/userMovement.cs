using UnityEngine;

public class userMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;

    void Start()
    {

    }

    public float forwardMove = 700f;
    public float backwardMove = -700f;
    public float jumpMove = 700f;


    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey("d"))
        {
            rb.AddForce(forwardMove, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(backwardMove, 0, 0);
        }
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, jumpMove, 0);
        }
    }
}
