using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(HealthScript), typeof(InputScript))]
public class Player : MonoBehaviour
{
    [SerializeField] private Entity entity;
    [SerializeField] private HealthScript healthScript;
    [SerializeField] private InputScript inputScript;
    [SerializeField] private MoveScript moveScript;
    [SerializeField] private AttackScript attackScript;
    // Start is called before the first frame update
    void Start()
    {
        healthScript = GetComponent<HealthScript>();
        inputScript = GetComponent<InputScript>();
        attackScript = GetComponent<AttackScript>();

        healthScript.EntityHealth = entity.Health;
        attackScript.Strength = entity.StrengthValue;
        inputScript.Speed = entity.MoveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
