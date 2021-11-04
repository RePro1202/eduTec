using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandMarkSpot : MonoBehaviour
{
    public GameObject popUp;
    Player enterPlayer;

    public void Enter(Player player)
    {
        enterPlayer = player;
        popUp.GetComponent<GameObject>();

        
        popUp.SetActive(true);
    }

    public void Exit()
    {
        popUp.SetActive(false);
    }

}
