using UnityEngine;

public class SpeedBoost : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (!IsEffectActive) player.SetMoveSpeed(player.MoveSpeed * 2); //Check IsEffectActive then call player.SetMoveSpeed
    }
}
