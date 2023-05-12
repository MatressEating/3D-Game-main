using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEffect : ScriptableObject
{
    [SerializeField] protected float Duration = 0f;

    public bool IsActive => DurationRemaining > 0f;

    float DurationRemaining = 0f;

    public void EnableEffect()
    {
        DurationRemaining = Duration;
    }

    public virtual float Effect_Speed(float originalSpeed)
    {
        return originalSpeed;
    }

    
}
