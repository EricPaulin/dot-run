using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float JumpForce;

    // Shows in Inspection Menu
    [SerializeField]
    bool isGrounded = false;

    Rigidbody2D RB; 

    private void Awake() 
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Space = Jump
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            // Can Only Jump if Grounded
            if(isGrounded == true) 
            {
                RB.AddForce(Vector2.up * JumpForce);
                isGrounded = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (isGrounded == false)
            {
                isGrounded = true;
            }
        }
    }


}
