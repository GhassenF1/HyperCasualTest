using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthControl : MonoBehaviour
{
    public Animator animationController;
    
    public GameObject theEnd;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    // Update is called once per frame
    void Update()
    {
        if (MasterScript.health == 2)
        {
            Heart1.SetActive (false);
        }
        else if (MasterScript.health == 1)
        {
            Heart2.SetActive (false);
        }
        if (MasterScript.health <= 0)
        {
            Heart3.SetActive (false);
            animationController.SetBool("DeathParam", true);
            GetComponent<MovePlayer>().enabled = false;
            theEnd.SetActive (true);
            // GameObject.Find("other_object_name").GetComponent(B).enabled = false;
           
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //Debug.Log (other); 

        if (other.gameObject.tag == "Enemy")
        {
            MasterScript.health -=1;
            
            animationController.SetBool("Stumble", true);
            //Debug.Log (HealthControl.health);
        }
    }

    
}
