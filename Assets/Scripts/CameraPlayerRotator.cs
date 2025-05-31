using UnityEngine;

public class CameraPlayerRotator : MonoBehaviour
{
    public Transform target;                // The object the camera follows (usually the player)
    public Vector2 rotationSpeed = new Vector2(120f, 90f);
    public float distance = 5.0f;
    public Vector2 pitchLimits = new Vector2(-30, 60);
    public float smoothTime = 0.1f;

    private float yaw;
    private float pitch;
    private Vector3 currentVelocity;

    void Start()
    {
        // Optional: initialize pitch/yaw based on current rotation
        Vector3 angles = transform.eulerAngles;
        yaw = angles.y;
        pitch = angles.x;
    }

    void LateUpdate()
    {
        if (Input.GetMouseButton(1)) // Right mouse button
        {
            yaw += Input.GetAxis("Mouse X") * rotationSpeed.x * Time.deltaTime;
            pitch -= Input.GetAxis("Mouse Y") * rotationSpeed.y * Time.deltaTime;
            pitch = Mathf.Clamp(pitch, pitchLimits.x, pitchLimits.y);
        }

        Quaternion rotation = Quaternion.Euler(pitch, yaw, 0f);
        Vector3 desiredPosition = target.position - rotation * Vector3.forward * distance;

        transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref currentVelocity, smoothTime);
        transform.rotation = rotation;

        // Important: Do NOT rotate the player here
    }
}
