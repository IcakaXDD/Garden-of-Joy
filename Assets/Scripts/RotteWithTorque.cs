using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ChargeSpinOnKey : MonoBehaviour
{
    public Vector3 rotationAxis = Vector3.up;
    public float acceleration = 5f;         // How quickly it builds up speed
    public float maxSpeed = 50f;            // Maximum angular speed
    public float decayRate = 3f;            // How fast it slows down

    private Rigidbody rb;
    private float currentSpeed = 0f;
    private bool isHoldingKey = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.angularDamping = 0f; // We handle decay manually
    }

    void Update()
    {
        isHoldingKey = Input.GetKey(KeyCode.R);
    }

    void FixedUpdate()
    {
        if (isHoldingKey)
        {
            // Increase spin speed up to max
            currentSpeed += acceleration * Time.fixedDeltaTime;
            currentSpeed = Mathf.Clamp(currentSpeed, 0f, maxSpeed);
        }
        else
        {
            // Gradually reduce spin speed
            currentSpeed = Mathf.MoveTowards(currentSpeed, 0f, decayRate * Time.fixedDeltaTime);
        }

        // Apply angular velocity in world space
        rb.angularVelocity = rotationAxis.normalized * currentSpeed;
    }
}
