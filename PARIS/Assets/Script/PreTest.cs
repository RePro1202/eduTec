using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreTest : MonoBehaviour
{
    private Image image;
    public GameObject LB;
    public GameObject RB;
    public GameObject NextB;
    public AudioClip Result;
    AudioSource audioSource;


    [SerializeField]
    private Sprite[] sprites;

    [SerializeField]
    private Sprite[] sprites2;

    private int index = 1;

    int a = 0, b = 0, c = 0, d = 0; // 휴식, 미식, 사진, 모험
    int result;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();

        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void NextImage()
    {

        if (sprites.Length == index)
        {
            MyCase();
            index = 0;
            a = 0; b = 0; c = 0; d = 0;
            audioSource.PlayOneShot(Result, 1);
        }
        else
        {
            image.sprite = sprites[index];
            index++;
        }
    }

    public void Click_LB()
    {
        NextImage();
        TestCase(true);
    }

    public void Click_RB()
    {
        NextImage();
        TestCase(false);
    }

    public void TestCase(bool LB)
    {
        bool lb = LB;

        switch (index) {
            case 1: 
                if (lb) c++; else a++;
                break;
            case 2:
                if (lb) b++; else d++;
                break;
            case 3:
                if (lb) a++; else b++;
                break;
            case 4:
                if (lb) d++; else c++;
                break;
            case 5:
                if (lb) a++; else d++;
                break;
            case 6:
                if (lb) d++; else b++;
                break;
            case 7:
                if (lb) a++; else c++;
                break;
            case 8:
                if (lb) b++; else c++;
                break;
        }
    }

    public void MyCase()
    {

        if (a >= b)
        {
            if (c >= d)
            {
                if (a >= c)
                {
                    image.sprite = sprites2[0];
                }
                else
                    image.sprite = sprites2[2];
            }
            else
            {
                if(a >= d)
                {
                    image.sprite = sprites2[0];
                }
                else
                    image.sprite = sprites2[3];
            }
        }
        else
        {
            if (c >= d)
            {
                if (b >= c)
                {
                    image.sprite = sprites2[1];
                }
                else
                    image.sprite = sprites2[2];
            }
            else
            {
                if (b >= d)
                {
                    image.sprite = sprites2[1];
                }
                else
                    image.sprite = sprites2[3];
            }
        }

        LB.GetComponent<GameObject>();
        RB.GetComponent<GameObject>();
        NextB.GetComponent<GameObject>();

        LB.SetActive(false);
        RB.SetActive(false);
        NextB.SetActive(true);
    }
}
