using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoIntro : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //  LoadingSceneManager.LoadScene("INTRODUCTION");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SceneChange()
    {
        LoadingSceneManager.LoadScene("INTRODUCTION");
    }
}

