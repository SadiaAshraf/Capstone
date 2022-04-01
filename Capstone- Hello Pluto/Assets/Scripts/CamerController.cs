using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    public GameObject Player;
    public float offSet;
    public float offSettSmoothness;
   // private Vector3 playerposition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = new Vector3 (Player.transform.position.x + offSet, Player.transform.position.y +2 ,transform.position.z );


        //if (playerposition.transform.localScale.x > 0f)
        //{
        //    playerposition = new Vector3(Player.transform.position.x + offSet, transform.position.y, transform.position.z);
        //}
        //else
        //{
        //    playerposition = new Vector3(Player.transform.position.x - offSet, transform.position.y, transform.position.z);
        //}


        
    }
}
