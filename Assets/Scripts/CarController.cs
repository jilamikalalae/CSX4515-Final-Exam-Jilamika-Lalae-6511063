using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;
    public float turnSpeed = 100f;

    void Update()
    {
        // Don't move if game is paused
        if (Time.timeScale == 0) return;

        // Get input from arrow keys or WASD
        float moveInput = Input.GetAxis("Vertical");   // W/S or Up/Down
        float turnInput = Input.GetAxis("Horizontal"); // A/D or Left/Right

        // Move car forward/backward
        transform.Translate(Vector3.forward * moveInput * speed * Time.deltaTime);
        
        // Turn car left/right
        transform.Rotate(Vector3.up * turnInput * turnSpeed * Time.deltaTime);
    }
}