using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControlScript : MonoBehaviour
{
    //[SerializeField] Button _startButton;
    //[SerializeField] Button _optionsButton;
    //[SerializeField] Button _exitButton;

    void Start()
    {
        //_startButton.onClick.AddListener(delegate { StartButtonClick(_startButton); });
        //_optionsButton.onClick.AddListener(delegate { OptionsButtonClick(_optionsButton); });
        //_exitButton.onClick.AddListener(delegate { ExitButtonClick(_exitButton); });
    }

    void Update()
    {

    }

    public void StartButtonClick(Button button)
    {
        SceneManager.LoadScene("impact");
    }

    public void OptionsButtonClick(Button button)
    {
        //if (!GameApplicationManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
            //GameApplicationManager.Instance.IsOptionMenuActive =true;
        }
    }

    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }
}
