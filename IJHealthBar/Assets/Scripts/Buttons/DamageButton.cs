using UnityEngine;

public class DamageButton : ButtonTrigger
{
    [SerializeField] private int _damage = 10;

    public override void OnClick()
    {
        _healther.TakeDamage(_damage);
    }
}
