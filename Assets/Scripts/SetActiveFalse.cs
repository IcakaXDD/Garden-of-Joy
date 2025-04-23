using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveFalse : MonoBehaviour
{
    public List<GameObject> thingsToDissapear = new List<GameObject>();
    public void Dissapear()
    {
        foreach(GameObject go in thingsToDissapear)
        {
            go.SetActive(false); 
        }  
    }
}
