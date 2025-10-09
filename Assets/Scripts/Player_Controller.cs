using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vel = rb.velocity;
        if (Input.GetKey(KeyCode.RightArrow))
            rb.velocity = new Vector3(3f, vel.y, vel.z);
        if (Input.GetKey(KeyCode.LeftArrow))
            rb.velocity = new Vector3(-3f, vel.y, vel.z);
        if (Input.GetKeyDown(KeyCode.Space))
            rb.velocity = new Vector3(vel.x, 5f, vel.z);
    }
}
