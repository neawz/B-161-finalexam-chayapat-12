using UnityEngine;

public class ShieldBuff : PowerUpBase
{
    public override void ApplyEffect(Player player)
    {
        player.SetInvulnerability(true);
    }
}
