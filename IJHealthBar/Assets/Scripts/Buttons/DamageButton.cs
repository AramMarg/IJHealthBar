using UnityEngine;

public class DamageButton : ButtonClicker
{
    [SerializeField] private int _damage = 10;
    [SerializeField] private DamageHealthCalculator _damageHealthCalculator;

    public override void OnClick()
    {
        _damageHealthCalculator.TakeDamage(_damage);
    }
}
