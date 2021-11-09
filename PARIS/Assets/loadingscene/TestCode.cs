using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      //  LoadingSceneManager.LoadScene("MAINSCENE");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneChange()
    {
        LoadingSceneManager.LoadScene("MAINSCENE");
    }
}
