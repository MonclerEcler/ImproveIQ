using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;

public class CardCollector : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI ScoreText;

    public UIMemoryCards UIMemoryCards;

    private Card _firstCard;
    private Card _secondCard;
    private int _countCards;
    private int _scorePointAdd;

    private void Start()
    {
        FindCards();
        ScoreText.text = "Score:" + _scorePointAdd.ToString();
    }

    public void FindCards()
    {
        Card[] cards = FindObjectsOfType<Card>();
        _countCards = cards.Length;

        for (int i = 0; i < cards.Length; i++)
        {
            cards[i].SetCardCollector(this);
        }
    }

    public void OpenCard(Card card)
    {
        if (_firstCard == null)
        {
            _firstCard = card;
        }
        else
        {
            _secondCard = card;
            Invoke(nameof(CompareCards), 0.7f);
        }
    }

    private void CompareCards()
    {
        if (_firstCard.Index == _secondCard.Index)
        {
            Destroy(_firstCard.gameObject);
            Destroy(_secondCard.gameObject);
            _countCards -= 2;
            _scorePointAdd += 10;
            ScoreText.text = "Score:" + _scorePointAdd.ToString();

            if (_countCards < 2)
            {
                UIMemoryCards.TimeOverCanvas.SetActive(true);
                Time.timeScale = 0f;
                Debug.Log("YOU WIN GAME");
            }
        }
        else
        {
            _firstCard.CardAnimation();
            _secondCard.CardAnimation();
            _scorePointAdd -= 5;
            ScoreText.text = "Score:" + _scorePointAdd.ToString();
        }

        _secondCard = null;
        _firstCard = null;
    }

    public bool TwoCardsClosed()
    {
        return _secondCard == null;
    }

    public void BackBtn()
    {
        SceneManager.LoadScene(0);
    }

    public void RestartBtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
