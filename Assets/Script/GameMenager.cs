using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenager : MonoBehaviour
{
    public float restartDelay = 1F;
    
    public GameObject levelCompleteUI;
    public GameObject GameOverUI;
    public void GameFinish()
    {
        levelCompleteUI.SetActive(true);
        FindObjectOfType<PlayerMovement>().enabled = false;
    }
    public void GameOver()
    {
        GameOverUI.SetActive(true);
        FindObjectOfType<PlayerMovement>().enabled = false;
        Invoke(nameof(Restart), restartDelay);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
