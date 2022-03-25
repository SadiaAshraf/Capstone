using UnityEngine;

/// <summary>
/// This script attaches to ‘Background’ object, and would move it up if the object went down below the viewport border. 
/// This script is used for creating the effect of infinite movement. 
/// </summary>

public class RepeatingBackground : MonoBehaviour
{

    public Vector2 startPos;
    private float repeatbg;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatbg = GetComponent<BoxCollider2D>().size.y / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < startPos.y - repeatbg)
        {
            transform.position = startPos;
            Debug.Log("transform posotion = " + startPos.y);
        }
    }




}




// [Tooltip("vertical size of the sprite in the world space. Attach box collider2D to get the exact size")]
// public float verticalSize = -5;

// public  void Update()
// {
//     if (transform.position.y < -verticalSize) //if sprite goes down below the viewport move the object up above the viewport
//     {
//         RepositionBackground();
//     }
// }

//public  void RepositionBackground() 
// {
//     Vector2 groundOffSet = new Vector2(0, verticalSize *Time.deltaTime * 0.75f);
//     transform.position = (Vector2)transform.position + groundOffSet;
// }