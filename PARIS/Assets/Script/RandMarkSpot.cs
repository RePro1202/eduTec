using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandMarkSpot : MonoBehaviour
{
    public GameObject popUp;
    public GameObject BackGround;
    public GameObject Quiz;
    public GameObject inUI;
    Player enterPlayer;

    public void Enter(Player player)
    {
        enterPlayer = player;
        popUp.GetComponent<GameObject>();
        BackGround.GetComponent<GameObject>();
        Quiz.GetComponent<GameObject>();

        BackGround.SetActive(true);
        popUp.SetActive(true);
        inUI.SetActive(false);
    }

    public void Exit()
    {
        BackGround.SetActive(false);
        popUp.SetActive(false);
        Quiz.SetActive(false);
        inUI.SetActive(true);
    }

    public void re_Std()
    {
        Quiz.SetActive(false);
    }

}
