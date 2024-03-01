using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button backButton;
    void Start()
    {
        backButton.onClick.AddListener(backMenu);
        
    }

   
   void backMenu(){
    SceneManager.LoadScene("MainMenu");   
    }
}
