using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void ThrowPick()
    {

    }
    public void ThrowDetach(GameObject obj)
    {
        Destroy(obj);
        Score.ballscore += 1;
    }
    public void ThrowHeld()
    {
        
    }
}
