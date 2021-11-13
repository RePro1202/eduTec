using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class textblink : MonoBehaviour
{

    Text flashingText;

    // Start is called before the first frame update
    void Start()
    {
        flashingText = GetComponent<Text>();
        StartCoroutine(BlinkText());

    }

    public IEnumerator BlinkText()
    {
        while (true)
        {
            flashingText.text = "";
            yield return new WaitForSeconds(.5f);
            flashingText.text = "Tap to Start Travel!";
            yield return new WaitForSeconds(1.0f);
        }
    }
}

