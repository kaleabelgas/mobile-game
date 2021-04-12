using System;
using UnityEngine;

public class PlayerEventHandler : MonoBehaviour
{
    public event Action OnActionButtonPressed;
    [SerializeField] private GameObject canvas;

    private ScoreUpdaterUI scoreUpdaterUI;
    private HealthScript healthScript;
    private MeleeAttackScript meleeAttackScript;


    private void Awake()
    {
        canvas = GameObject.FindGameObjectWithTag("Canvas");

        healthScript = GetComponent<HealthScript>();
        meleeAttackScript = GetComponent<MeleeAttackScript>();
        scoreUpdaterUI = canvas.GetComponent<ScoreUpdaterUI>();    
    }


    private void Start()
    {
        CurrencyScript.OnUpdateCoins += scoreUpdaterUI.UpdateCoinsUI;
        // healthScript.OnDeath += do something
        OnActionButtonPressed += meleeAttackScript.DoAttack;
    }

    public void ActionButtonPressed()
    {
        OnActionButtonPressed?.Invoke();
    }
}
