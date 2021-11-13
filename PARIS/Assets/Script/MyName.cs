using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MyName : MonoBehaviour
{
    public InputField inputField;
    public Text nameText;
    string str;

    // Start is called before the first frame update
    void Start()
    {
        nameText.GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void Myname()
    {
        str = inputField.text;
        nameText.text = str;
    }
}
