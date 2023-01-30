using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public Button playButton;

    public void PlayGame()
    {
        SceneManager.LoadScene("CubicleRun");
    }
}