using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MasterScript : MonoBehaviour
{
    public GameObject theEnd;

    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    public static float health = 3;
    // Start is called before the first frame update
    public void ButtonMoveScene(string scene)
   {

       CoinScore.Score=0;
       MasterScript.health =3;
       Heart1.SetActive (true);
       Heart2.SetActive (true);
       Heart3.SetActive (true);
       theEnd.SetActive (false);
       SceneManager.LoadScene(scene);
       MovePlayer.Speed = 3;
   }
}
