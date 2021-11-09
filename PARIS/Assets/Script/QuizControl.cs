using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class QuizControl : MonoBehaviour
{
    public RandMarkSpot randmark;

    public GameObject button_true;
    public GameObject button_false;
    public GameObject button_01;
    public GameObject button_02;
    public GameObject button_03;

    private int index = 1;

    private Image image;

    [SerializeField]
    private Sprite[] sprites;

    [SerializeField]
    public int[] answer;

    [SerializeField]
    public int[] type;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
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
}
