using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadingSceneManager : MonoBehaviour
{
    public static string nextScene;
    [SerializeField] Image progress_bar;


    // Start is called before the first frame update
    private void Start()
    {
        StartCoroutine(LoadScene());
    }
    
    public static void LoadScene(string sceneName)
     {
        nextScene = sceneName;
        SceneManager.LoadScene("LoadingScene");
    }
    IEnumerator LoadScene()
    {
        yield return null;
        AsyncOperation op = SceneManager.LoadSceneAsync(nextScene);
        op.allowSceneActivation = false;
        float timer = 0.0f;
        while(!op.isDone)
        {
            yield return null;
            timer+= Time.deltaTime;
            if(op.progress<0.9f)
            {
                progress_bar.fillAmount = Mathf.Lerp(progress_bar.fillAmount, op.progress, timer);
                if(progress_bar.fillAmount>=op.progress)
                {
                    timer = 0f;

                }
            }
            else
            {
                progress_bar.fillAmount = Mathf.Lerp(progress_bar.fillAmount, 1f, timer);
                if(progress_bar.fillAmount==1.0f)
                {
                    op.allowSceneActivation = true;
                    yield break;

                }
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
