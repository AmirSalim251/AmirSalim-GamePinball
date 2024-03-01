using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider player;
    public float multiplier;
    public Color color;
    public AudioManager audioManager;
    // untuk mengakses score manager
  public ScoreManager scoreManager;


    private Renderer renderer;
    private Animator animator;

    public VFXManager VFXManager;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        // karena material ada pada component Rendered, maka kita ambil renderernya
	renderer = GetComponent<Renderer>();

	// kita akses materialnya dan kita ubah warna nya saat Start
  renderer.material.color = color;

  // ambil animatornya saat Start
  animator = GetComponent<Animator>();

        
    }

   /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision other) {
        if(other.collider == player){
            // ambil rigidbody nya lalu kali kecepatannya sebanyak multiplier agar bisa memantul lebih cepat
		Rigidbody bolaRig = player.GetComponent<Rigidbody>();
    bolaRig.velocity *= multiplier;

    animator.SetTrigger("trig");
    audioManager.PlaySFX(other.transform.position);
    Debug.Log("Kena!");
    VFXManager.PlayVFX(other.transform.position);
          scoreManager.AddScore(2);


        }
    }

  

}
