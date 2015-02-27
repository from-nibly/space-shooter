using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {
  public GameObject explosion;
  public GameObject playerExplosion;

  void OnTriggerEnter(Collider other) {
    if (other.tag == "Boundary") {
      return;
    }
    Destroy(other.gameObject);
    Destroy(gameObject);
    GameObject ex = Instantiate(explosion, transform.position, transform.rotation) as GameObject;
    ex.rigidbody.angularVelocity = rigidbody.angularVelocity;
    ex.rigidbody.velocity = rigidbody.velocity;
    if (other.tag == "Player") {
      GameObject pEx = Instantiate(playerExplosion, other.transform.position, other.transform.rotation) as GameObject;
      pEx.rigidbody.angularVelocity = -1 * rigidbody.angularVelocity;
    }
  }

}
