using UnityEngine;

public abstract class EnemyBase : MonoBehaviour
{
    protected Player player;
    protected bool playerFound = false;

    protected virtual void Start()
    {
        CheckIfPlayerExists();
    }
    
    protected void CheckIfPlayerExists()
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


