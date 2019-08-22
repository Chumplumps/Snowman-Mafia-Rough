using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public  class MainMenuManager : MonoBehaviour
{
    public TextMeshProUGUI antiAliasingText;
    public int antiAliasingLevel;
   public  void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void AntiAliasing()
    {
        QualitySettings.antiAliasing = antiAliasingLevel;
        antiAliasingText.text = antiAliasingLevel.ToString();
        antiAliasingLevel++;
        if (antiAliasingLevel == 5)
        {
            antiAliasingLevel = 0;
        }

        
       
       

    }
}
