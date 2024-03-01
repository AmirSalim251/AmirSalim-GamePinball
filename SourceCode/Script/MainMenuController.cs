using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
     public Button playButton,exitButton,creditButton;

  private void Start()
  {
    playButton.onClick.AddListener(PlayGame);
    exitButton.onClick.AddListener(ExitGame);
    creditButton.onClick.AddListener(creditGame);

  }

  public void PlayGame()
  {
    SceneManager.LoadScene("MainPinball");
  }
   private void ExitGame()
  {
    Application.Quit();
  }
  private void creditGame(){
     SceneManager.LoadScene("Credit");
  }
}
