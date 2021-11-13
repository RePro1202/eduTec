using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inGameUI : MonoBehaviour
{
    public GameObject ingame;

    public Text Clear_culture;
    public Text Clear_social;
    public Text Clear_art;
    public Text Clear_languge;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void SetUI(QuizControl quiz)
    {
        Color color;
        color.r = 0.127f;
        color.g = 0.518f;
        color.b = 0f;
        color.a = 0.5f;

        if (quiz.name == "Quiz_culture")
        {
            Clear_culture.color = color;
            
        }
        if (quiz.name == "Quiz_social")
        {
            Clear_social.color = color;
        }
        if (quiz.name == "Quiz_art")
        {
            Clear_art.color = color;
        }
        if (quiz.name == "Quiz_language")
        {
            Clear_languge.color = color;
        }
    }

    public void Out()
    {
        ingame.SetActive(false);
    }
    
    public void Show()
    {
        ingame.SetActive(true);
    }
}
