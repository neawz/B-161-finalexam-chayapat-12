using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    protected bool IsEffectActive = false;

    public abstract void ApplyEffect(Player player); //Abstract method that ApplyEffect to Player, Require sub-class to sign
}
