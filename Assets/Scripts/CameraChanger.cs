using UnityEngine;

public class CameraChanger : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    
    public void ChangeCamera()
    {
        camera1.SetActive(false);
        camera2.SetActive(true);
    }
}
