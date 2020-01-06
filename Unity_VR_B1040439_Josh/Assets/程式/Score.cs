using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int ballscore;
    public GameObject all;
    public GameObject text;

    void Update()
    {
        if (ballscore >= 7)
        {
            Destroy(all);
            Destroy(text);
        }
    }
}
