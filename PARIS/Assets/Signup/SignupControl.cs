using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignupControl : MonoBehaviour
{
    private Image image;

    [SerializeField]
    private Sprite[] sprites;

    private int index = 1;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    public void NextImage()
    {
        if (sprites.Length == index)
        {
            index = 0;
        }
        image.sprite = sprites[index];
        index++;

        Debug.Log(index);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
