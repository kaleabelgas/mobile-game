using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceScript : MonoBehaviour
{
    private float experience;

    public void AddExp(float amount)
    {
        experience += amount;
    }
    public float Exerience
    {
        get { return experience; }
    }
}
