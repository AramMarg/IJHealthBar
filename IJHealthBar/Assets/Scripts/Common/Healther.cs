using System;
using UnityEngine;

public class Healther : MonoBehaviour
{
    [SerializeField] private int _amor = 5;

    private int _health = 100;
    private int _healInInventory;
    private int _minHealth = 0;
    private int _maxHealth = 100;
    private int _minDamage = 1;

    public event Action<int> HealthChanged;

    public void TakeDamage(int damage)
    {
        damage -= _amor; 

        if (damage <= _minHealth)
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

            Destroy(gameObject);
        }

        HealthChanged?.Invoke(_health);
    }

    public void Heal(int heal)
    {
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

        HealthChanged?.Invoke(_health);
    }
}
