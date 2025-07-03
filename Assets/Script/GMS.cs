using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GMS : MonoBehaviour
{
    public static int lives = 5;
    public static void startGame()
    {
        //lives = 5;
    }
    public static void lifeLoss(int life)
    {
        lives += life;
    }
}
