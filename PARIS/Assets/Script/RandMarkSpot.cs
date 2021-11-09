using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandMarkSpot : MonoBehaviour
{
    public GameObject popUp;
    public GameObject BackGround;
    public GameObject Quiz;
    Player enterPlayer;

    public void Enter(Player player)
    {
        enterPlayer = player;
        popUp.GetComponent<GameObject>();
        BackGround.GetComponent<GameObject>();
        Quiz.GetComponent<GameObject>();

        BackGround.SetActive(true);
        popUp.SetActive(true); 
    }

    public void Exit()
    {
        BackGround.SetActive(false);
        popUp.SetActive(false);
        Quiz.SetActive(false);
    }

}
