using UnityEngine;

public abstract class HealthBarViewer : MonoBehaviour
{
    [SerializeField] protected Health Health;

    protected void OnEnable()
    {
        Health.HealthChanged += OnHealthChanged;
    }

    protected void OnDisable()
    {
        Health.HealthChanged -= OnHealthChanged;
    }

    public abstract void OnHealthChanged(int helth);
}
