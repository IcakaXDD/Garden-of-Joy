using UnityEngine;

public class CameraRotator : MonoBehaviour
{

    [SerializeField] float rotationSpeed;

    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
    }
}
