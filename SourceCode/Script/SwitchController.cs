using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwitchController : MonoBehaviour
{
    private enum SwitchState
  {
    Off,
    On,
    Blink
  }
    public Collider bola;
    public Material offMaterial;
    private SwitchState state;

    public Material onMaterial;
      public ScoreManager scoreManager;
     
      public SFXManager audioManagerOn,audioManagerOff;
          public VFXManager VFXManager;
          


    // menyimpan state switch apakah nyala atau mati
    private bool isOn;
// komponen renderer pada object yang akan diubah
    private Renderer renderer;

    /// <summary>
    /// OnTriggerEnter is called when the Collider other enters the trigger.
    /// </summary>
    /// <param name="other">The other Collider involved in this collision.</param>
    

    // Start is called before the first frame update
    void Start()
    {
        // ambil renderernya
  renderer = GetComponent<Renderer>();

	// set switch nya mati baik di state, maupun materialnya
	Set(false);
    StartCoroutine(BlinkTimerStart(5));

        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
       if (other == bola)
  {
		Toggle();
     VFXManager.PlayVFX(other.transform.position);
        Debug.Log("HIT!");
  }
    }

    private void Set(bool active)
{
	if (active == true)
	{
		 state = SwitchState.On;
      renderer.material = onMaterial;
      StopAllCoroutines();
	}
	else
	{
		 state = SwitchState.Off;
      renderer.material = offMaterial;
      StartCoroutine(BlinkTimerStart(5));
	}
}

private IEnumerator Blink(int times)
{
	state = SwitchState.Blink;

    for (int i = 0; i < times; i++)
    {
      renderer.material = onMaterial;
      yield return new WaitForSeconds(0.5f);
      renderer.material = offMaterial;
      yield return new WaitForSeconds(0.5f);
    }

    state = SwitchState.Off;

    StartCoroutine(BlinkTimerStart(5));
}

private void Toggle()
  {
    if (state == SwitchState.On)
    {
      scoreManager.AddScore(3);
      audioManagerOff.PlaySFX(bola.transform.position);
      Set(false);
    }
    else
    {
      scoreManager.AddScore(3);
      audioManagerOn.PlaySFX(bola.transform.position);
      Set(true);
    }
  }

  private IEnumerator BlinkTimerStart(float time)
  {
    yield return new WaitForSeconds(time);
    StartCoroutine(Blink(2));
  }
}
