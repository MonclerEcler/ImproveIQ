using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MathProblem : MonoBehaviour
{
    [SerializeField] TMP_Text firstNumber;
    [SerializeField] TextMeshProUGUI secondNumber;
    [SerializeField] TextMeshProUGUI answer1;
    [SerializeField] TextMeshProUGUI answer2;
    [SerializeField] TextMeshProUGUI rightOrWrong;
    [SerializeField] TextMeshProUGUI ScoreText;
    [SerializeField] TextMeshProUGUI Operetor;
    int randomFirstNumber;
    private int RandomFirstNumber
    {
        get { return randomFirstNumber; }
        
        set
        {
            randomFirstNumber = value;
            firstNumber.color = Color.magenta;
        }
    }
    [SerializeField] int randomSecondNumber;
    [SerializeField] int currentAnswer;
    public int CurrentAnswer { get => currentAnswer; }

    public List<int> easyMathList = new List<int>();
    public static bool AdditionTypeMathSelected = true;

    private int _firstNumberProblem;
    private int _secondNumberProblem;
    private int _answerOne;
    private int _answerTwo;
    private int _dispalyRandomAnswer;
    private int _randomAnswearPlacment;
    private int _scorePoint;

    private void Start()
    {
        DisplayMathProblem();
        ScoreText.text = "Score:" + _scorePoint.ToString();
    }

    public void DisplayMathProblem()
    {
        RandomFirstNumber = Random.Range(0, easyMathList.Count + 1);
        randomSecondNumber = Random.Range(0, easyMathList.Count + 1);

        _firstNumberProblem = randomFirstNumber;
        _secondNumberProblem = randomSecondNumber;

        //_answerOne = _firstNumberProblem + _secondNumberProblem;

        if (AdditionTypeMathSelected == true)
        {
            Addition();
            Operetor.text = " + ";
            Operetor.color = Color.red;
            Debug.Log("Addition");
        }

        else if (AdditionTypeMathSelected == false)
        {
            Subtraction();
            Operetor.text = " - ";
            Operetor.color = Color.yellow;
            Debug.Log("Subraction");
        }
       
        _dispalyRandomAnswer = Random.Range(0, 2);

        if (_dispalyRandomAnswer == 0)
        {
            _answerTwo = _answerOne + Random.Range(1, 10);
        }
        else
        {
            _answerTwo = _answerOne - Random.Range(1, 10);
        }

        firstNumber.text = "" + _firstNumberProblem;
        secondNumber.text = "" + _secondNumberProblem;

        _randomAnswearPlacment = Random.Range(0, 2);

        if (_randomAnswearPlacment == 0)
        {
            answer1.text = "" + _answerOne;
            answer2.text = "" + _answerTwo;
            currentAnswer = 0;
        }
        else
        {
            answer1.text = "" + _answerTwo;
            answer2.text = "" + _answerOne;
            currentAnswer = 1;
        }
    }

    public void ButtonAnswer1()
    {
        if (currentAnswer == 0)
        {
            rightOrWrong.enabled = true;
            rightOrWrong.color = Color.magenta;
            rightOrWrong.text = ("Correct");
            _scorePoint += 10;
            ScoreText.text = "Score:" + _scorePoint.ToString();
            Invoke("TurnOffText", 1);
        }
        else
        {
            rightOrWrong.enabled = true;
            rightOrWrong.color = Color.red;
            rightOrWrong.text = ("Try Again");
            _scorePoint -= 5;
            ScoreText.text = "Score:" + _scorePoint.ToString();
            Invoke("TurnOffText", 1);
        }
    }

    public void ButtonAnswer2()
    {
        if (currentAnswer == 1)
        {
            rightOrWrong.enabled = true;
            rightOrWrong.color = Color.magenta;
            rightOrWrong.text = ("Correct");
            _scorePoint += 10;
            ScoreText.text = "Score:" + _scorePoint.ToString();
            Invoke("TurnOffText", 1);
        }
        else
        {
            rightOrWrong.enabled = true;
            rightOrWrong.color = Color.red;
            rightOrWrong.text = ("Try Again");
            _scorePoint -= 5;
            ScoreText.text = "Score:" + _scorePoint.ToString();
            Invoke("TurnOffText", 1);
        }
    }

    public void TurnOffText()
    {
        if (rightOrWrong != null)
            rightOrWrong.enabled = false;
        DisplayMathProblem();
    }

    public void Addition()
    {
        _answerOne = _firstNumberProblem + _secondNumberProblem;
    }

    public void Subtraction()
    {
        _answerOne = _firstNumberProblem - _secondNumberProblem;
    }
}
