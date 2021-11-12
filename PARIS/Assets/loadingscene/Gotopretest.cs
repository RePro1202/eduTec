using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gotopretest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //  LoadingSceneManager.LoadScene("PreTest");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SceneChange()
    {
        LoadingSceneManager.LoadScene("PreTest");
    }
}
