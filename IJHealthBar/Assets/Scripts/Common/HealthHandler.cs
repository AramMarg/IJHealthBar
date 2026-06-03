using UnityEngine;

public class HealthHandler : MonoBehaviour
{
    [SerializeField] private Armor _armor;
    [SerializeField] private Inventory _inventory;

    private int _minDamage = 1;
    private int _minHealth = 0;
    private int _maxHealth = 100;

    public int CalculateDamage(int damage)
    {
        damage = _armor.ApplyArmor(damage);

        if (damage <= 0)
        {
            damage = _minDamage;
        }

        return damage;
    }

    public int TakeHealthFromInventory(int currentHealth)
    {
        int tempHealth;

        currentHealth = Mathf.Clamp(_inventory.GetHealFromInventory(), _minHealth, _maxHealth);

        tempHealth = _inventory.GetHealFromInventory() - currentHealth;

        if (tempHealth > 0)
        {
            _inventory.SetHealInInventory(tempHealth);
        }
        else
        {
            _inventory.SetHealInInventory(_minHealth);
        }

        return currentHealth <= 0 ? 0 : currentHealth;
    }

    public void CalculateHealInInventoty(int heal)
    {
        _inventory.AddHeal(heal);
    }
}
