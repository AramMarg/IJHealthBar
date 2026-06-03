using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int _healInInventory;

    public void SetHealInInventory(int heal) =>
        _healInInventory = heal;

    public int AddHeal(int heal) =>
        _healInInventory += heal;

    public int GetHealFromInventory() =>
        _healInInventory;
}
