using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class QuizControl : MonoBehaviour
{
    public Text question;
    public Text answer1;
    public Text answer2;

    private int counter = 1;

    string qText, aText1, aText2;

    // Start is called before the first frame update
    void Start()
    {
        NextQuiz();
        question.GetComponent<Text>().text = qText;
        answer1.GetComponent<Text>().text = aText1;
        answer2.GetComponent<Text>().text = aText2;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void QuizFuc()
    {
        switch (counter) {
            case 1:
                qText = " question Text 01 ";
                aText1 = " answer 1";
                aText2 = " answer 2";
                break;
            case 2: 
                qText = " question Text 02 ";
                aText1 = " answer 3";
                aText2 = " answer 4";
                break;
            case 3:
                qText = " question Text 03 ";
                aText1 = " answer 5";
                aText2 = " answer 6";
                break;
            case 4:
                qText = " question Text 04 ";
                aText1 = " answer 7";
                aText2 = " answer 8";
                break;
        }
    }

    public void NextQuiz()
    {
        if(counter <= 4)
        {
            QuizFuc();
            question.GetComponent<Text>().text = qText;
            answer1.GetComponent<Text>().text = aText1;
            answer2.GetComponent<Text>().text = aText2;

            counter++;
        }
        else if(counter > 4)
        {
            counter = 1;

            QuizFuc();
            question.GetComponent<Text>().text = qText;
            answer1.GetComponent<Text>().text = aText1;
            answer2.GetComponent<Text>().text = aText2;
            counter++;
            this.gameObject.SetActive(false);
        }
    }
}
