using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SoundTestingMenuControlScript : MonoBehaviour
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
        SceneManager.UnloadSceneAsync("SceneSoundTesting");
        SceneManager.LoadScene("SceneMainMenu2");
    }
}
