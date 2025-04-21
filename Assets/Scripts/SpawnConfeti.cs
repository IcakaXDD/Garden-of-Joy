using System;
using System.Collections;
using UnityEngine;

public class SpawnConfeti : MonoBehaviour
{
    public ParticleSystem confeti;

    public void PlayConfeti()
    {
        StartCoroutine(SpawnConfet());
    }

    private IEnumerator SpawnConfet()
    {
        yield return new WaitForSeconds(2);
        confeti.Play();
    }
}
