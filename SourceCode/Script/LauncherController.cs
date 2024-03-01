using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{ public Collider bola;
  public KeyCode input;

  public float maxTimeHold;
  public float maxForce;
  

  private Renderer renderer;
  private bool isHold;
  public Material materialHold,materialNotHold;

  private void Start()
  {
    renderer = GetComponent<Renderer>();
    isHold = false;
  
  }

  private void OnCollisionStay(Collision collision)
  {
    if (collision.collider == bola)
    {
      ReadInput(bola);
    }
  }

  private void ReadInput(Collider collider)
  {
    if (Input.GetKey(input) && !isHold)
    {
      StartCoroutine(StartHold(collider));
    }
  }

  private IEnumerator StartHold(Collider collider)
  {
    isHold = true;

    float force = 0.0f;
    float timeHold = 0.0f;

    while (Input.GetKey(input))
    {
      force = Mathf.Lerp(0, maxForce, timeHold/maxTimeHold);

      yield return new WaitForEndOfFrame();
      timeHold += Time.deltaTime;
      renderer.material = materialHold;
    }

    collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
    renderer.material = materialNotHold;
    isHold = false;
  }
}
