using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonMainMenu : MonoBehaviour
{

    [Header("Main Button")]
    [SerializeField] Button MemoryCardsButton;
    [SerializeField] Button MathematicsButton;
    [SerializeField] Button LogicsButton;
    [SerializeField] Button ExitButton;


    [Header("Canvas")]
    [SerializeField] GameObject ChooseTypeCardsCanvas;
    [SerializeField] GameObject ChooseTypeTaskMath;
    [SerializeField] GameObject ButtonCanvas;


    [Header("Choosen Button")]
    [SerializeField] Button FruitsButton;
    [SerializeField] Button NumberButton;

    [Header("Audio")]
    private AudioSource clikedButton;

    private void Awake()
    {
        clikedButton = GetComponent<AudioSource>();
    }


    public void LoadingMemoryCards()
    {
        clikedButton.Play();
        ChooseTypeCardsCanvas.SetActive(true);
    }

    public void BackMemoryCards()
    {
        clikedButton.Play();
        ChooseTypeCardsCanvas.SetActive(false);
    }

    public void LoadingMathematics()
    {
        clikedButton.Play();
        SceneManager.LoadScene(2);
    }

    public void LoadingPuzzleMenu()
    {
        clikedButton.Play();
        SceneManager.LoadScene(4);
    }

    public void Exit()
    {
        clikedButton.Play();
        Application.Quit();
    }

    public void NumberCardsBtn()
    {
        clikedButton.Play();
        CardsSpawner.FruitsSelected = false;
        SceneManager.LoadScene(1);
    }

    public void FruitsCardBtn()
    {
        clikedButton.Play();
        CardsSpawner.FruitsSelected = true;
        SceneManager.LoadScene(1);
    }

    public void ChooseTypeTaskMathCanvas()
    {
        clikedButton.Play();
        ChooseTypeTaskMath.SetActive(true);
        ButtonCanvas.SetActive(false);
    }

    public void Addition()
    {
        clikedButton.Play();
        MathProblem.AdditionTypeMathSelected = true;
        SceneManager.LoadScene(2);
    }

    public void Subtraction()
    {
        clikedButton.Play();
        MathProblem.AdditionTypeMathSelected = false;
        SceneManager.LoadScene(2);
    }
}
