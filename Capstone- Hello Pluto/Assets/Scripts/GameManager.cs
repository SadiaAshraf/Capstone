using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static int Score;
    public Text ScoreCard;

    public static int Elements;
    public Text ElementsCard;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         ScoreCard.text = "Score = "+ Score;
         ElementsCard.text = "Elements Collected = " + Elements;
        
    }


    
}
