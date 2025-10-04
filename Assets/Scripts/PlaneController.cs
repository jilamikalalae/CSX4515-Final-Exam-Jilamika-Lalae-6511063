using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float speed = 15f;
    public float pitchSpeed = 50f;
    public float yawSpeed = 50f;

    void Update()
    {
        // Don't move if paused
        if (Time.timeScale == 0) return;

        // Get input
        float pitchInput = Input.GetAxis("Vertical");   // Up/Down - pitch
        float yawInput = Input.GetAxis("Horizontal");   // Left/Right - turn

        // Always move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Pitch (tilt up/down)
        transform.Rotate(Vector3.right * pitchInput * pitchSpeed * Time.deltaTime * -1);
        
        // Yaw (turn left/right)
        transform.Rotate(Vector3.up * yawInput * yawSpeed * Time.deltaTime);
    }
}