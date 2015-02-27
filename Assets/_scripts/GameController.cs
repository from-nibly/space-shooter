using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
  public GameObject hazard;

  void Start() {
    SpawnWaves();
  }

  void SpawnWaves() {
    Instantiate(hazard);
  }
}
