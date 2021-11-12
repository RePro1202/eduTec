using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class QuizControl : MonoBehaviour
{
    public RandMarkSpot randmark;
    public GameObject OX;

    public GameObject button_true;
    public GameObject button_false;
    public GameObject button_01;
    public GameObject button_02;
    public GameObject button_03;

    private int index = 1;
    private int score = 0;

    private Image image;
    private Image OX_image;

    [SerializeField]
    private Sprite[] sprites;
    [SerializeField]
    private Sprite[] OX_sprites;

    [SerializeField]
    public int[] answer;

    [SerializeField]
    public int[] type;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        OX_image = GetComponent<Image>();
        QuizFuc();
    }

    void OnDisable()
    {
        index = 0;
        image.sprite = sprites[index];
        QuizFuc();
        index++;
    }

    public void Click()
    {
        if (sprites.Length != index)
        {
            QuizFuc();

            image.sprite = sprites[index];
            index++;
        }
        else
        {
            randmark.Exit();
        }
    }

    public void QuizFuc()
    {
        button_01.GetComponent<Button>();
        button_02.GetComponent<Button>();
        button_03.GetComponent<Button>();
        button_true.GetComponent<Button>();
        button_false.GetComponent<Button>();

        if (type[index] == 0)    // ox문제
        {
            button_01.SetActive(false);
            button_02.SetActive(false);
            button_03.SetActive(false);

            button_true.SetActive(true);
            button_false.SetActive(true);
        }
        else if (type[index] == 1)  // 3지선다
        {
            button_01.SetActive(true);
            button_02.SetActive(true);
            button_03.SetActive(true);

            button_true.SetActive(false);
            button_false.SetActive(false);
        }
    }

    public void Onclick_Button_01()
    {
        OX_image = GetComponent<Image>();

        if (answer[index] == 1)
        {
            score++;
            OX_image.sprite = OX_sprites[1];
            OX.SetActive(true);
        }
        else
        {
            OX_image.sprite = OX_sprites[0];
            OX.SetActive(true);
        }

        Click();
    }

    public void Onclick_Button_02()
    {

    }

    public void Onclick_Button_03()
    {

    }

    public void Onclick_Button_true()
    {

    }

    public void Onclick_Button_false()
    {

    }

}
