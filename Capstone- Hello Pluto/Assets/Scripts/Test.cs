using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private MisileController controller = new MisileController();
    private MisileController enemymislile;
    void Start()
    {
        controller.movement();
        enemymislile = GameObject.Find("enemy").GetComponent<MisileController>();//as reference 
        enemymislile.movement();
        enemymislile.speed = 20;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
