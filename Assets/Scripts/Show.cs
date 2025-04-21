using System.Collections;
using UnityEngine;

public class Show : MonoBehaviour
{
    [SerializeField] ParticleSystem smoke;
    [SerializeField] ParticleSystem confeti;
    [SerializeField] GameObject prefab;

    IEnumerator Animate()
    { 
        smoke.Play();
        yield return new WaitForSeconds(2);
        prefab.SetActive(true);
        confeti.Play();
    }

    public void StartAnimate()
    { 
        StartCoroutine(Animate());
    }
}
