using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScore : MonoBehaviour
{
    public AudioSource audioSource;
    public static float Score = 0;
    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = Score.ToString();
        //Debug.Log(Score);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "GCoin")
        {
            
            Score += 5;
            Destroy(other.gameObject);
            audioSource.Play();
        }
        else if (other.tag == "SCoin")
        {
            
            Score += 1;
            Destroy(other.gameObject);
            audioSource.Play();
        }

    }
}
