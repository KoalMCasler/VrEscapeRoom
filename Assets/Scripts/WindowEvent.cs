using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WindowEvent : MonoBehaviour
{
    public AudioClip[] audioClips = new AudioClip[3];
    public AudioSource source;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            int randRoll = Random.Range(0,audioClips.Length);
            Debug.Log(randRoll);
            source.clip = audioClips[randRoll];
            source.Play();
        }   
    }
}
