using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    GameObject nearObject;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Zone")
        {
            nearObject = other.gameObject;
            RandMarkSpot randMark = nearObject.GetComponent<RandMarkSpot>();
            randMark.Enter(this);
        }

        Debug.Log(nearObject.name);
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Zone")
        {
            RandMarkSpot randMark = nearObject.GetComponent<RandMarkSpot>();
            randMark.Exit();
            nearObject = null;
        }
    }
}
