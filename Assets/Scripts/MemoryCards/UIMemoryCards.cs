using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMemoryCards : MonoBehaviour
{
    [Header("Canvas")]
    [SerializeField] GameObject PauseCanvas;
    public GameObject TimeOverCanvas;

    private AudioSource _clikedButton;

    private void Awake()
    {
        _clikedButton = GetComponent<AudioSource>();
    }
    public void BackToMenuButton()
    {
        _clikedButton.Play();
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void RestartButton()
    {
        _clikedButton.Play();
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseButton()
    {
        _clikedButton.Play();
        PauseCanvas.SetActive(true);
        Time.timeScale = 0f;
    }

    public void CountinueButton()
    {
        _clikedButton.Play();
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
}
