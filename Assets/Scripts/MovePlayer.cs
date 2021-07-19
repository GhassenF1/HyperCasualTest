using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public GameObject theEnd;
    public GameObject Character;
    public static float Speed = 2.5f; // the speed of the charachter moving forward.

    public float smoothness = 3f; // the speed of the player mouvement left and right.
    public bool canControl;

    private Vector3 position;
    private float width;
    private float height;

    void Awake()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;

        // Position used for the cube.
        position = new Vector3(0.0f, 0.0f, 0.0f);
    }
    
    void Update()
    {
        Vector3 deltaPosition = transform.forward * Speed;
         if( Input.touchCount > 0 )
         {
             Vector3 touchPosition = Input.GetTouch( 0 ).position;
             if ( touchPosition.x > Screen.width * 0.5f )
                 deltaPosition += transform.right * smoothness;
             else
                 deltaPosition -= transform.right * smoothness;
         }
         Character.transform.position += deltaPosition * Time.deltaTime ;

         if (Character.transform.position.y < -2f)
         {
             theEnd.SetActive (true);
         }

    }
        
}
