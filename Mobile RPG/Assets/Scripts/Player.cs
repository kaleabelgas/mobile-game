using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HealthScript), typeof(InputScript))]
public class Player : MonoBehaviour
{
    [SerializeField] private Entity player;
    [SerializeField] private HealthScript healthScript;
    [SerializeField] private InputScript inputScript;
    [SerializeField] private MoveScript moveScript;
    [SerializeField] private MeleeAttackScript attackScript;
    [SerializeField] private Weapon weapon;

    [SerializeField] private Transform weaponTransform;
    // Start is called before the first frame update
    void Awake()
    {
        healthScript = GetComponent<HealthScript>();
        inputScript = GetComponent<InputScript>();
        attackScript = GetComponent<MeleeAttackScript>();

        healthScript.EntityHealth = player.Health;

        weapon.AssignTransform(weaponTransform);

        attackScript.Strength = player.StrengthValue + weapon.AttackValue;
        attackScript.AttackRange = weapon.AttackRange;
        attackScript.WeaponTransform = weapon.WeaponTransform;
        attackScript.EnemyMask = weapon.EnemyMask;

        inputScript.Speed = player.MoveSpeed;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
