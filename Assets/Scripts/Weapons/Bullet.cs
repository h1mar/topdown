using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

  public GameObject impactEffect;

  void OnTriggerEnter2D(Collider2D other)
  {
    switch (other.gameObject.tag)
    {
      case "Box":
        Destroy(gameObject);
        Impact();
        break;
      case "Enemy":
        Destroy(gameObject);
        Impact();
        break;
    }
  }

  public void Impact()
  {
    Instantiate(impactEffect, transform.position, Quaternion.identity);
    Destroy(gameObject);
  }
}
