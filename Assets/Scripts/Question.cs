using System.Collections;
using System.Collections.Generic;


[System.Serializable]
public class Question
{
    public string questionText;
    public string optionA;
    public string optionB;
    public string Answer;

    void sorular(string qText, string o_A, string o_B, string answer)
    {
        qText = questionText;
        o_A = optionA;
        o_B = optionB;
        answer = Answer;
    }

}
