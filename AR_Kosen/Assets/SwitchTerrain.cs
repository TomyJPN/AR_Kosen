using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchTerrain : MonoBehaviour {
  [SerializeField]
  MeshRenderer mesh;

  [SerializeField]
  Terrain terrain1;

  [SerializeField]
  Terrain terrain2;

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {
    if (mesh.enabled) {
      terrain1.enabled = true;
      terrain2.enabled = true;
    }
    else {
      terrain1.enabled = false;
      terrain2.enabled = false;
    }
  }

  public void onExitBtn() {
    SceneManager.LoadScene("Title");
  }
}
