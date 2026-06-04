using UnityEngine;

public class HealButton : ButtonClicker
{
    [SerializeField] private int _heal = 10;
    [SerializeField] private HealHealthCalculator _healHealthCalculator;

    public override void OnClick()
    {
        _healHealthCalculator.Heal(_heal);
    }
}
