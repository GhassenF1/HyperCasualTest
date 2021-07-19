using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGame : MonoBehaviour
{
    public GameObject win;
    public Animator MaleAnimationController;

    public Animator FemaleAnimationController;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "MalePlayer")
        {
            MaleAnimationController.SetBool("Dance", true);
        }
        if (col.gameObject.tag == "FemalePlayer")
        {
            FemaleAnimationController.SetBool("Dance", true);
        }
        
        //MovePlayer.Speed =0f;
    }
    void OnTriggerExit(Collider other)
    {
        //GameObject.Find("Female").GetComponent<MovePlayer>().enabled = false;
        //GameObject.Find("Hulk").GetComponent<MovePlayer>().enabled = false;
        MovePlayer.Speed =0f;


        StartCoroutine(ExampleCoroutine());
        win.SetActive (true);
    }

    IEnumerator ExampleCoroutine()
    {
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

    }
}
