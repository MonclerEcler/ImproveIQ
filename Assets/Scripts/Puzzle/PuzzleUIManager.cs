using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleUIManager : MonoBehaviour
{
    public GameObject NextPicture;

    private AudioSource _clikedButton;

    private void Awake()
    {
        _clikedButton = GetComponent<AudioSource>();
    }

    public void PlayGame(int LevelNumber)
    {
        _clikedButton.Play();
        PlayerPrefs.SetInt("Level", LevelNumber);
        SceneManager.LoadScene(3);
    }
    public void OpenLink(string URL)
    {
        Application.OpenURL(URL);
    }

    public void BackButton()
    {
        _clikedButton.Play();
        SceneManager.LoadScene(0);
    }
    public void NextLevel()
    {
        _clikedButton.Play();
        PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1);
        SceneManager.LoadScene(4);
    }

    public void BacktoMenu()
    {
        _clikedButton.Play();
        SceneManager.LoadScene(5);
    }
}
