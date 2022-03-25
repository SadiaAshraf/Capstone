using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        jump();
    }

   virtual public void jump()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up);
        }
    }

}
