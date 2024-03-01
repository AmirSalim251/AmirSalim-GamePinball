using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
   // kita masukan audio source bgm disini
public GameObject sfxAudioSource;
   
	public void PlaySFX(Vector3 spawnPosition) { 
        // berbeda dengan bgm, disini kita buat script untuk 
	// memunculkan prefabnya pada posisi sesuai dengan parameternya
	GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    
    }
}
