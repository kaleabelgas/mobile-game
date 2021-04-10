using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    private bool isNearEnemy;
    public int Strength { get; set; }

    public void DoAttack()
    {
        Debug.Log("Attacked!" + Strength);
    }

}
