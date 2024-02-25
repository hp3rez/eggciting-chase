using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
   public void StartButton() {
        SceneManager.LoadSceneAsync("Tut1");
   }

   public void OptionsButton() {
        SceneManager.LoadSceneAsync("Options");
   }

   public void ExitButton() {
        Application.Quit();
   }

   public void HomeButton() {
          SceneManager.LoadSceneAsync("Home");
   }
}
