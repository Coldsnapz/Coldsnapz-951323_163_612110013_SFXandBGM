using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonControlScript : MonoBehaviour
{
    public void replay1()
    {
        SceneManager.UnloadSceneAsync("GameObjectLauncherUP");
        SceneManager.LoadScene("impact");
    }

    public void nextLevel()
    {
        SceneManager.LoadScene("SceneGameplay");
    }
}
