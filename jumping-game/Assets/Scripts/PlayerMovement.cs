using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float movementSpeed;
    public float forwardForce;
    public bool leftKey = false;
    public bool rightKey = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey("a"))
        {
            rightKey = false;
            leftKey = true;
        }

        if (Input.GetKey("d"))
        {
            leftKey = false;
            rightKey = true;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);

        if (leftKey)
        {
            rb.AddForce(movementSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rightKey)
        {
            rb.AddForce(-movementSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
