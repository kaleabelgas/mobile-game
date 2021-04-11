using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionButtonEventListener : MonoBehaviour
{
    public UnityEvent OnActionButtonPressed;

    public void ActionButtonPressed()
    {
        OnActionButtonPressed?.Invoke();
    }
}
