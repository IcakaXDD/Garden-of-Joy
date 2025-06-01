using UnityEngine;
using UnityEngine.UI;

public class ProgressUpdater : MonoBehaviour
{
    public Slider progressSlider;
    public GameObject button;
    private bool check =true;

    private void Update()
    {
        if (progressSlider.value == progressSlider.maxValue&&check)
        {
            button.SetActive(true);
            check = false;
        }
    }
    public void UpdateProgress()
    {
        progressSlider.value++;
    }
}
