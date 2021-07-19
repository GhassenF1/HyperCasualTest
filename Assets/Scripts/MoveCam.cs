using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCam : MonoBehaviour
{
    public GameObject Character;
    public GameObject Character2;
    public GameObject MainCam;


    // Update is called once per frame
    void Update()
    {
        if (Character.activeSelf)
        {
            // Get the z position of the player while it is moving.
            float zPos = Character.transform.position.z;

            // move the camera with player on the z axis xhile keeping the original distance.
            MainCam.transform.position = new Vector3(0,4,zPos + 8f);
        }
        else if (Character2.activeSelf)
        {
            // Get the z position of the player while it is moving.
            float zPos = Character2.transform.position.z;

            // move the camera with player on the z axis xhile keeping the original distance.
            MainCam.transform.position = new Vector3(0,4,zPos + 8f);
        }
        
    }
}
