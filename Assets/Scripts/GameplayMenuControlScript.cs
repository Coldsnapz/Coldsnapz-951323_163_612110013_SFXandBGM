using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayMenuControlScript : MonoBehaviour
{
    [SerializeField] Button _backButton;
    void Start()
    {
        _backButton.onClick.AddListener(delegate{ BackToMainMenuButtonClick(_backButton); });
    }

    void Update()
    {
        
    }
    
    public void BackToMainMenuButtonClick(Button backButton)
    {
        SceneManager.UnloadSceneAsync("SceneGameplay");
        SceneManager.LoadScene("SceneMainMenu2");
    }
}
