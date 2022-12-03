using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFinish : MonoBehaviour
{
    public GameMenager gameMenager;
    
    void OnTriggerEnter()
    {
        gameMenager.GameFinish();
    }
}
