using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Database database;
    public Question currentQuestion;

    public Text questionText;
    public Text optionAText;
    public Text optionBText;

    public int randomIndex;

    public GameObject endGame;

    public void Awake()
    {
        getQuestion();
    }

    public void Update()
    {
        if(database.questions.Count == 0)
        {
            endGame.SetActive(true);
        }
    }

    void getQuestion()
    {
        randomIndex = Random.Range(0, database.questions.Count - 1);
        currentQuestion = database.questions[randomIndex];

        questionText.text = currentQuestion.questionText;
        optionAText.text = currentQuestion.optionA;
        optionBText.text = currentQuestion.optionB;
    }

    public void toAnswer(string option)
    {
        database.questions.RemoveAt(randomIndex);

        if(option == currentQuestion.Answer)
        {
            Debug.Log("Tebrikler doğru cevapladınız.");
            getQuestion();
        }

        else
        {
            Debug.Log("Maalesef yanlış cevapladınız.");
            getQuestion();
        }
    }
}
