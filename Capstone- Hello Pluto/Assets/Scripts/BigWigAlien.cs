using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigWigAlien : Aliens
{
    Vector2 Pi = new Vector2(62, 0);  //initial and final positions
    Vector2 Pf = new Vector2(82, 0);
    float sp = 3; //speed
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var fraction = (Mathf.Sin(Time.time * sp) + 1.0) / 2.0;
        //transform.position = Vector2.Lerp(Pi, Pf, fraction);
    }
}
