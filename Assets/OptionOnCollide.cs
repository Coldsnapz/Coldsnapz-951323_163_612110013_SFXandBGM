using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionOnCollide : MonoBehaviour
{
 void OnCollisionEnter(Collision collision)
 {
     if (collision.gameObject.name == "Impact")
     {
         SceneManager.UnloadSceneAsync("impact");
         SceneManager.LoadScene("GameObjectLauncherUP");
     }
 }
}
