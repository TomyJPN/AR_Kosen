using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {
  [SerializeField]
  GameObject MarkerCanvas;

  [SerializeField]
  GameObject CreditCanvas;

  // Start is called before the first frame update
  void Start() {

  }

  public void onMarkerBtn() {
    MarkerCanvas.SetActive(true);
  }
  public void onMarkerExit() {
    MarkerCanvas.SetActive(false);
  }
  public void onCreditBtn() {
    CreditCanvas.SetActive(true);
  }
  public void onCreditExit() {
    CreditCanvas.SetActive(false);
  }
  public void onStartBtn() {
    FadeManager.Instance.LoadScene("MainScene", 1f);
  }
}
