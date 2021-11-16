using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class QuizControl : MonoBehaviour
{
    public RandMarkSpot randmark;
    public GameObject OX;
    public GameObject Show_result;

    public GameObject button_true;
    public GameObject button_false;
    public GameObject button_01;
    public GameObject button_02;
    public GameObject button_03;

    private int index = 0;
    private int score = 0;

    private Image image;
    private Image OX_image;

    public AudioClip Wrong;
    public AudioClip Correct;
    public AudioClip Suceed;
    public AudioClip Failed;
    AudioSource audioSource;

    [SerializeField]
    private Sprite[] sprites;
    [SerializeField]
    private Sprite[] OX_sprites;

    [SerializeField]
    public int[] answer;

    [SerializeField]
    public int[] type;

    public Text Text_result;
    public inGameUI inUI;

    // Start is called before the first frame update
    void Start()
    {
        button_01.GetComponent<Button>();
        button_02.GetComponent<Button>();
        button_03.GetComponent<Button>();
        button_true.GetComponent<Button>();
        button_false.GetComponent<Button>();

        OX_image = OX.GetComponentInChildren<Image>();
        image = GetComponent<Image>();
        QuizFuc();

        audioSource = gameObject.GetComponent<AudioSource>();
    }

    void OnDisable()
    {
        index = 0;
        score = 0;
        image.sprite = sprites[index];
        QuizFuc();
    }

    private void Update()
    {
        
    }

    public void Click()
    {
        if (sprites.Length != index + 1)
        {
            index++;
            QuizFuc();
            image.sprite = sprites[index];
        }
        else
        {
            result();
        }
    }

    public void ExitQuiz()
    {
        Show_result.SetActive(false);
        randmark.Exit();
    }

    public void QuizFuc()
    { 
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
        if (answer[index] == 1)
        {
            score++;
            OX_image.sprite = OX_sprites[0];
            OX.SetActive(true);
            audioSource.PlayOneShot(Correct, 1);
        }
        else
        {
            OX_image.sprite = OX_sprites[1];
            OX.SetActive(true);
            audioSource.PlayOneShot(Wrong, 1);
        }

        StartCoroutine(delayTIme());

    }

    public void Onclick_Button_02()
    {
        if (answer[index] == 2)
        {
            score++;
            OX_image.sprite = OX_sprites[0];
            OX.SetActive(true);
            audioSource.PlayOneShot(Correct, 1);
        }
        else
        {
            OX_image.sprite = OX_sprites[1];
            OX.SetActive(true);
            audioSource.PlayOneShot(Wrong, 1);
        }

        StartCoroutine(delayTIme());

    }

    public void Onclick_Button_03()
    {
        if (answer[index] == 3)
        {
            score++;
            OX_image.sprite = OX_sprites[0];
            OX.SetActive(true);
            audioSource.PlayOneShot(Correct, 1);
        }
        else
        {
            OX_image.sprite = OX_sprites[1];
            OX.SetActive(true);
            audioSource.PlayOneShot(Wrong, 1);
        }

        StartCoroutine(delayTIme());
    }

    public void Onclick_Button_true()
    {
        if (index > 0)
        {
            if (answer[index] == 4)
            {
                score++;
                OX_image.sprite = OX_sprites[0];
                OX.SetActive(true);
                audioSource.PlayOneShot(Correct, 1);
            }
            else
            {
                OX_image.sprite = OX_sprites[1];
                OX.SetActive(true);
                audioSource.PlayOneShot(Wrong, 1);
            }

            StartCoroutine(delayTIme());
        }
        else
        {
            Click();
        }
    }

    public void Onclick_Button_false()
    {
        if (index == 0)
        {
            randmark.Exit();
        }
        else
        {
            if (answer[index] == 5)
            {
                score++;
                OX_image.sprite = OX_sprites[0];
                OX.SetActive(true);
                audioSource.PlayOneShot(Correct, 1);
            }
            else
            {
                OX_image.sprite = OX_sprites[1];
                OX.SetActive(true);
                audioSource.PlayOneShot(Wrong, 1);
            }

            StartCoroutine(delayTIme());
        }
    }

    IEnumerator delayTIme()
    {
        yield return new WaitForSeconds(1);
        OX.SetActive(false);
        Click();
    }

    public void result()
    {
        int temp2;

        temp2 = sprites.Length;

        if(score > sprites.Length/2)
        {
            string temp = sprites.Length-1 + "문제 중 " + score + "개를 맞춰 통과했습니다!";
            Text_result.text = temp;
            Text_result.color = Color.blue;
            inUI.SetUI(this);
            audioSource.PlayOneShot(Suceed,1);

        }
        else
        {
            string temp = sprites.Length - 1 + "문제 중 " + score + "개를 맞춰 불합격 입니다!";
            Text_result.text = temp;
            Text_result.color = Color.red;
            audioSource.PlayOneShot(Failed, 1);
        }
        Show_result.SetActive(true);
    }
}
