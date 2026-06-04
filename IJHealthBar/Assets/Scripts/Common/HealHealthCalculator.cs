using UnityEngine;

public class HealHealthCalculator : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Inventory _inventory;

    public void Heal(int heal)
    {
        if (heal < 0)
        {
            return;
        }

        if (_health.Current + heal <= _health.Max)
        {
            _health.SetCurrent(_health.Current + heal);
        }
        else 
        {
            _health.SetCurrent(_health.Max);

            _inventory.AddHeal(_health.Current + heal - _health.Max);
        }
    }
}
