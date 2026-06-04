using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int Current { get; private set; } = 100;
    public int Min { get; } = 0;
    public int Max { get; } = 100;

    public event Action<int> HealthChanged;

    public void SetCurrent(int current)
    {
        Current = current;

        if (Current == Min)
        {
            HealthChanged?.Invoke(Min);
        }

        HealthChanged?.Invoke(Current);
    }
}
