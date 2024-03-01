using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
   // reference ke text score nya
	// disini menggunakan TMP_Text karena yang dipakai adalah TextMeshPro
	// Jangan salah ya, yang nantinya dimasukan ke sini adalah text angka, bukan title nya
  public Text scoreText;
	
	// reference ke score manager
  public ScoreManager scoreManager;
  public GameObject gameOver;

  private void Update()
  {
		if(gameOver.activeSelf == false){
    scoreText.text = scoreManager.score.ToString();
    }
  }
}
