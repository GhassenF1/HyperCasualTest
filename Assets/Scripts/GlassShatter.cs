using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassShatter : MonoBehaviour
{
    public GameObject theEnd;
    public AudioSource audioSource;
    public GameObject Glass;

    public Animator MaleAnimationController;
    public Animator FemaleAnimationController;
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "MalePlayer")
        {
            MaleAnimationController.SetBool("Punch", true);
            this.gameObject.SetActive(false);
            Glass.SetActive(true);
            audioSource.Play();
        }
        if (col.gameObject.tag == "FemalePlayer")
        {
            FemaleAnimationController.SetBool("DeathParam", true);
            theEnd.SetActive (true);
        }

    }
}
