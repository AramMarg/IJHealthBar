using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private HealthHandler _healthHandler;

    private int _health = 100;
    private int _minHealth = 0;
    private int _maxHealth = 100;

    public event Action<int> HealthChanged;

    public int GetMaxHealth() =>
          _maxHealth;

    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            return;
        }

        damage = _healthHandler.CalculateDamage(damage);

        _health -= damage;

        if (_health <= _minHealth)
        {
            _health = _healthHandler.TakeHealthFromInventory(_health);
        }

        if (_health == _minHealth)
        {
            HealthChanged?.Invoke(_minHealth);
        }

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
            _healthHandler.CalculateHealInInventoty(heal);
        }
        else if (_health + heal >= _maxHealth)
        {
            _health = _maxHealth;

            _healthHandler.CalculateHealInInventoty(_health + heal - _maxHealth);
        }
        else if (_health + heal < _maxHealth)
        {
            _health += heal;
        }

        HealthChanged?.Invoke(_health);
    }
}
