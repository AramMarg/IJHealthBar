using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private Armor _armor;
    [SerializeField] private Inventory _inventory;

    private int _health = 100;
    private int _minHealth = 0;
    private int _maxHealth = 100;
    private int _minDamage = 1;
    private int _healInInventory;

    public event Action<int> HealthChanged;

    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            return;
        }

        damage = _armor.ApplyArmor(damage);

        _healInInventory = _inventory.GetHealFromInventory();

        if (damage == 0)
        {
            damage = _minDamage;
        }

        _health = Mathf.Clamp(_health - damage, _minHealth, _maxHealth);

        if (_health == _minHealth && _healInInventory >= damage)
        {
            _healInInventory -= damage;

            _health += damage;
        }

        if (_health == _minHealth)
        {
            HealthChanged?.Invoke(_minHealth);
        }

        _inventory.SetHealInInventory(_healInInventory);

        HealthChanged?.Invoke(_health);
    }

    public void Heal(int heal)
    {
        if (heal < 0)
        {
            return;
        }

        if (_health == _maxHealth)
        {
            _healInInventory += heal;
        }
        else if (_health + heal >= _maxHealth)
        {
            _health = _maxHealth;

            _healInInventory += _health + heal - _maxHealth;
        }
        else if (_health + heal < _maxHealth)
        {
            _health += heal;
        }

        _inventory.SetHealInInventory(_healInInventory);

        HealthChanged?.Invoke(_health);
    }

    public int GetMaxHealth() =>
          _maxHealth = 100;
}
