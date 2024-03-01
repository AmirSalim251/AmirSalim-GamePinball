using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXAudioController : MonoBehaviour
{
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        Destroy(gameObject, 1.0f);
    }
}
