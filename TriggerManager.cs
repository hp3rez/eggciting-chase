using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerManager : MonoBehaviour
{
    public Text text;
    void OnTriggerEnter2D(Collider2D collide) {
        if(collide.gameObject.CompareTag("NextLevel")) {
            SceneManager.LoadSceneAsync("Tut2");
        } else if(collide.gameObject.CompareTag("Text")) {
            text.text = "Watch out for Traps!";
        } 
    }
}
