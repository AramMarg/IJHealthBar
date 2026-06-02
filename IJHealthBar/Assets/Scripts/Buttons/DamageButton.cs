using UnityEngine;

public class DamageButton : ButtonClicker
{
    [SerializeField] private int _damage = 10;

    public override void OnClick()
    {
        Health.TakeDamage(_damage);
    }
}
