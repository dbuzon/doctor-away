using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Retry() {
        SceneManager.LoadScene("Level 1");
    }

    public void Quit() {
        SceneManager.LoadScene("Menu");
    }
}
