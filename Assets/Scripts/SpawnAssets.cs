using UnityEngine;
using UnityEngine.UI;

public class SpawnAssets : MonoBehaviour
{
    public Button spawnPrefab1;
    public Button spawnPrefab2;
    public Button spawnPrefab3;

    
    private void OnMouseDown()
    {
        spawnPrefab1.gameObject.SetActive(true);
        spawnPrefab2.gameObject.SetActive(true);
        spawnPrefab3.gameObject.SetActive(true);
    }
}
