using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public new AudioSource audio;
    public AudioClip audioClip;
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.name == "Sphere")
        {
            
        }
        
    }
}
