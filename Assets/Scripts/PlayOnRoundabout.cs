using TMPro;
using UnityEngine;

public class PlayOnRoundabout : MonoBehaviour
{
    public TextMeshProUGUI text;
    public Camera newcamera;
    public TextMeshProUGUI rotateText;
    public GameObject oldCamera;
    

    private void OnTriggerEnter(Collider other)
    {
        text.gameObject.SetActive(true);
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            oldCamera.SetActive(false);
            text.gameObject.SetActive(false);
            newcamera.gameObject.SetActive(true);
            rotateText.gameObject.SetActive(true);
        }
    }
}
