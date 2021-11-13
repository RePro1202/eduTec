using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gotostart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //  LoadingSceneManager.LoadScene("Start Scene");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SceneChange()
    {
        Time.timeScale = 1f;
        LoadingSceneManager.LoadScene("Start Scene");
    }
}
