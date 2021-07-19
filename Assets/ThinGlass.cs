using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThinGlass : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject Glass;
    public Animator MaleAnimationController;

    public Animator FemaleAnimationController;
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "MalePlayer")
        {
            MaleAnimationController.SetBool("Fall", true);
            this.gameObject.SetActive(false);
            Glass.SetActive(true);
            audioSource.Play();
        }
        else if (col.gameObject.tag == "FemalePlayer")
        {
            //Vector3 v = new Vector3(0f,0f,0f);
            //FemaleAnimationController.transform.rotation= Quaternion.Euler(v); 
            //FemaleAnimationController.SetBool("ThinGlass", true);
            //GameObject.Find("Female").GetComponent<MovePlayer>().enabled = false;
            //Animator animator = col.gameObject.GetComponent<Animator>();
            //animator.SetBool("ThinGlass", true);
            MovePlayer.Speed =1.3f;
        }

    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "FemalePlayer")
        {
            //Animator animator = col.gameObject.GetComponent<Animator>();
            //FemaleAnimationController.SetBool("ThinGlass", false);
            MovePlayer.Speed =2.5f;
        }
    }
}
