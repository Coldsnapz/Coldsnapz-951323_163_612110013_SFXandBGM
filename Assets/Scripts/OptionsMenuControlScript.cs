using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class OptionsMenuControlScript : MonoBehaviour
{
    [SerializeField] Dropdown _dropdownDifficulty;
    [SerializeField] Toggle _toggleMusic;
    [SerializeField] Toggle _toggleSFX;
    [SerializeField] Button _backButton;

    void Start()
    {
        _dropdownDifficulty.value= GameApplicationManager.Instance.DifficultyLevel;
        _toggleMusic.isOn = GameApplicationManager.Instance.MusicEnabled;
        _toggleSFX.isOn = GameApplicationManager.Instance.SFXEnabled;
        _dropdownDifficulty.onValueChanged.AddListener(delegate{ DropdownDifficultyChanged(_dropdownDifficulty); });
        _toggleMusic.onValueChanged.AddListener(delegate{OnToggleMusic(_toggleMusic);});
        _toggleSFX.onValueChanged.AddListener(delegate{ OnToggleSFX(_toggleSFX);});
        _backButton.onClick.AddListener(delegate{ BackButtonClick(_backButton); });
    }
    void Update()
    {
        
    }
    public void BackButtonClick(Button Button)
    {
        SceneManager.UnloadSceneAsync("SceneOptions");
        GameApplicationManager.Instance.IsOptionMenuActive =false;
    }
    public void DropdownDifficultyChanged(Dropdown dropdown)
    {
        GameApplicationManager.Instance.DifficultyLevel = dropdown.value;
    }
    public void OnToggleMusic(Toggle toggle)
    {
        GameApplicationManager.Instance.MusicEnabled = _toggleMusic.isOn;
    }
    public void OnToggleSFX(Toggle toggle)
    {
        GameApplicationManager.Instance.SFXEnabled = _toggleSFX.isOn;
    }
}
