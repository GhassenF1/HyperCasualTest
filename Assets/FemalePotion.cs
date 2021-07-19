using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemalePotion : MonoBehaviour
{
    public GameObject FemalePlayer;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MalePlayer")
        {
            other.gameObject.SetActive(false);
            FemalePlayer.transform.position = other.transform.position;
            FemalePlayer.SetActive(true);
            
            Destroy(this.gameObject);
        }
        if (other.tag == "FemalePlayer")
        {
            Destroy(this.gameObject);
        }
        

    }
}
