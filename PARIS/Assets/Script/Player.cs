using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    GameObject nearObject;

    bool culture = false;

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Zone" && culture == false)
        {
            nearObject = other.gameObject;
            RandMarkSpot randMark = nearObject.GetComponent<RandMarkSpot>();
            QuizControl quiz = nearObject.GetComponent<QuizControl>();
            randMark.Enter(this);
            culture = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Zone")
        {
            RandMarkSpot randMark = nearObject.GetComponent<RandMarkSpot>();
            randMark.Exit();
            nearObject = null;
            culture = false;
        }
    }
}
