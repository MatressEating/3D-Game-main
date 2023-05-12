using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Effects/Speedy", fileName = "Effect_Speedy")]
public class Effect_Speedy : BaseEffect
{
    public override float Effect_Speed(float originalSpeed)
    {
        return originalSpeed * -1f;
    }
}
