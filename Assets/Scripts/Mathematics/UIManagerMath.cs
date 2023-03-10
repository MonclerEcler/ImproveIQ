using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerMath : MonoBehaviour
{
    public GameObject TimeOverCanvas;
    private AudioSource _clikedButton;
    private void Awake()
    {
        _clikedButton = GetComponent<AudioSource>();
    }

    public void TimeOver()
    {
        TimeOverCanvas.SetActive(true);
    }

    public void RestartButton()
    {
        _clikedButton.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExtiButton()
    {
        _clikedButton.Play();
        SceneManager.LoadScene(0);
    }

}
