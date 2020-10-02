using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MainMenuControlScriptBGMSFX : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField] Button _startButton;
    [SerializeField] Button _optionsButton;
    [SerializeField] Button _exitButton;
    [SerializeField] Button _HelpButton;
    [SerializeField] Button _SoundTestingSceneButton;

    AudioSource audiosourceButtonUI;
    [SerializeField] AudioClip audioclipHoldOver;

    void Start()
    {
        this.audiosourceButtonUI = this.gameObject.AddComponent<AudioSource>();
        this.audiosourceButtonUI.outputAudioMixerGroup = SingletonSoundManager.Instance.Mixer.FindMatchingGroups("UI")[0];

        SetupButtonsDelegate();

        if (!SingletonSoundManager.Instance.BGMSource.isPlaying)
            SingletonSoundManager.Instance.BGMSource.Play();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (audiosourceButtonUI.isPlaying)
            audiosourceButtonUI.Stop();
        Debug.Log("asd");
        audiosourceButtonUI.PlayOneShot(audioclipHoldOver);
    }

    void SetupButtonsDelegate()
    {
        _startButton.onClick.AddListener(delegate { StartButtonClick(_startButton); });
        _optionsButton.onClick.AddListener(delegate { OptionsButtonClick(_optionsButton); });
        _HelpButton.onClick.AddListener(delegate { HelpButtonClick(_HelpButton); });
        _exitButton.onClick.AddListener(delegate { ExitButtonClick(_exitButton); });
        _SoundTestingSceneButton.onClick.AddListener(delegate { SoundTestingButtonClick(_SoundTestingSceneButton); });
    }

    public void StartButtonClick(Button button)
    {
        SceneManager.LoadScene("Impact");
    }

    public void OptionsButtonClick(Button button)
    {
        if (!GameApplicationManager.Instance.IsOptionMenuActive)
        {
            SceneManager.LoadScene("SceneOptions", LoadSceneMode.Additive);
            GameApplicationManager.Instance.IsOptionMenuActive = true;
        }
    }

    public void HelpButtonClick(Button button)
    {
        if (SingletonSoundManager.Instance.BGMSource.isPlaying)
            SingletonSoundManager.Instance.BGMSource.Stop();
        SceneManager.LoadScene("SceneHelp");
    }

    public void SoundTestingButtonClick(Button button)
    {

        if (SingletonSoundManager.Instance.BGMSource.isPlaying)
            SingletonSoundManager.Instance.BGMSource.Stop();

        SceneManager.LoadScene("SceneSoundTesting");
    }
    public void ExitButtonClick(Button button)
    {
        Application.Quit();
    }
}