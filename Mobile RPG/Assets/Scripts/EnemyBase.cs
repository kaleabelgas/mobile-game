using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    

    protected Player player;
    protected bool playerFound = false;
    
    protected IEnumerator LookForPlayer(int timeToLookForPlayer)
    {
        player = FindObjectOfType<Player>();
        if (player != null)
        {
            playerFound = true;
            Debug.Log("Player Found!");
            yield return null;
        }
        else
            yield return new WaitForSeconds(timeToLookForPlayer);
    }
}


