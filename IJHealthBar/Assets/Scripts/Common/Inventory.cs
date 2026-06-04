using UnityEngine;

public class Inventory : MonoBehaviour
{
    private int _heal;

    public void SetHeal(int heal) =>
        _heal = heal;

    public int AddHeal(int heal) =>
        _heal += heal;

    public int GetHeal() =>
        _heal;
}

