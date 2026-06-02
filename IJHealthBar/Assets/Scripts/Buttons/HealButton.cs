using UnityEngine;

public class HealButton : ButtonClicker
{
    [SerializeField] private int _heal = 10;

    public override void OnClick()
    {
        Health.Heal(_heal);
    }
}
