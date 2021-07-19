using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MalePotion : MonoBehaviour
{
    public GameObject MalePlayer;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "FemalePlayer")
        {
            other.gameObject.SetActive(false);
            MalePlayer.transform.position = other.transform.position;
            MalePlayer.SetActive(true);
            
            Destroy(this.gameObject);
        }
        if (other.tag == "MalePlayer")
        {
            Destroy(this.gameObject);
        }
        

    }
}
