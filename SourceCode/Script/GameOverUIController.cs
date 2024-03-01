using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    // reference untuk button
  public Button mainMenuButton;
  [SerializeField]private GameObject canvas;

  private void Start()
  {
    canvas.SetActive(false);
    mainMenuButton.onClick.AddListener(MainMenu);
  }

  public void MainMenu()
  {
		// kembali ke main menu
    SceneManager.LoadScene("MainMenu");
  }
}
