using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageControl : MonoBehaviour
{
    private Image image;
    public GameObject Quest;

    [SerializeField]
    private Sprite[] sprites;

    private int index = 1;
    // �̹��� ���� ���� �ʿ�������??

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    void OnDisable()
    {
        index = 1;
        image.sprite = sprites[index-1];
    }

    public void NextImage()
    {
        if (sprites.Length == index)
        {
            Quest.GetComponent<GameObject>();
            Quest.SetActive(true);
            index = 0;
        }  
        image.sprite = sprites[index];
        index++;
    }

    public void BackImage()
    {
        if (index > 1)
        {
            image.sprite = sprites[index - 2];
            index--;
        }
    }

}
