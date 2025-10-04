using UnityEngine;

public class SumoController : MonoBehaviour
{
    public float moveForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Don't move if paused
        if (Time.timeScale == 0) return;

        // Get input
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // Apply force to move
        Vector3 movement = new Vector3(moveX, 0, moveZ) * moveForce;
        rb.AddForce(movement);
    }
}