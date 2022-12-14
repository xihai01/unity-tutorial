using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float movementSpeed;
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
        rb.AddForce(0, 0, -movementSpeed * Time.deltaTime);

        if (leftKey)
        {
            rb.AddForce(movementSpeed * Time.deltaTime, 0, 0);
        }

        if (rightKey)
        {
            rb.AddForce(-movementSpeed * Time.deltaTime, 0, 0);
        }
        Debug.Log("world");
    }
}
