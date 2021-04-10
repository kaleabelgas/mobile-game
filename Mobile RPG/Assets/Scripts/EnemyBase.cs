using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    protected Player player;
    protected bool playerFound = false;
    
    protected void LookForPlayer()
    {
        player = FindObjectOfType<Player>();
        if (player != null)
        {
            playerFound = true;
            Debug.Log("Player Found!");
        }
        else
            Debug.Log("No Player Found!");
    }
}


