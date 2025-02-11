using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class BallSFX : MonoBehaviour
{
    public AudioSource source;

    void OnCollisionEnter(Collision collision)
    {
        source.Play();
    }
}
