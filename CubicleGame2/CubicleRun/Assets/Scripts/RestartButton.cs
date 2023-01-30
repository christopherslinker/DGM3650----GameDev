using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public Button restartButton;
    private PlayerController playerControllerScript;

    public void Start()
    {
        playerControllerScript =  GameObject.Find("DudeGuy").GetComponent<PlayerController>();
    }

    public void Update()
    {
        if (playerControllerScript.gameOver == true)
        {
            restartButton.gameObject.SetActive(true);
        }

    }

    public void RestartGame()
    {
        SceneManager.LoadScene("CubicleRun");
    }
}