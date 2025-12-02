using UnityEngine;

public class SuperDebuff : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        if (!IsEffectActive) //Check IsEffectActive then call Methods from player
        {
            player.SetMoveSpeed(player.MoveSpeed / 4);
            player.SetInvulnerability(false);
        }
    }
}
