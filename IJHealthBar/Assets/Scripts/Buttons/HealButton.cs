using UnityEngine;

public class HealButton : ButtonTrigger
{
    [SerializeField] private int _heal = 10;

    public override void OnClick()
    {
        _healther.Heal(_heal);
    }
}
