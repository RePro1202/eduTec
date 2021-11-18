using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inGameUI : MonoBehaviour
{
    public GameObject ingame;
    public GameObject Arch;

    public Text Clear_culture;
    public Text Clear_social;
    public Text Clear_art;
    public Text Clear_language;

    private bool c = false, s = false, a = false, l = false;

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
        Color color, color_white;
        color.r = 0.127f;
        color.g = 0.518f;
        color.b = 0f;
        color.a = 0.5f;

        color_white.r = 1f;
        color_white.g = 1f;
        color_white.b = 1f;
        color_white.a = 1f;

        if (quiz.name == "Quiz_culture")
        {
            Clear_culture.color = color;
            c = true;
        }
        if (quiz.name == "Quiz_social")
        {
            Clear_social.color = color;
            s = true;
        }
        if (quiz.name == "Quiz_art")
        {
            Clear_art.color = color;
            a = true;
        }
        if (quiz.name == "Quiz_language")
        {
            Clear_language.color = color;
            l = true;
        }
        if (quiz.name == "Quiz_final")
        {
            Clear_social.color = color;
            Clear_art.color = color_white;
            Clear_art.text = "축하합니다. 모든 확습을 완료했습니다";
        }
        else if(c && s && a && l)
        {
            Clear_culture.text = "";
            Clear_social.text = "에투알 개선문에서 퀴즈대결에 참가하세요";
            Clear_art.text = "";
            Clear_language.text = "";
            Clear_social.color = color_white;
            Arch.SetActive(true);
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
