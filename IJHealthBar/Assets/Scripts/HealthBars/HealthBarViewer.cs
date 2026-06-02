using UnityEngine;

public abstract class HealthBarViewer : MonoBehaviour
{
    [SerializeField] protected Health Health;

    protected void Awake()
    {
        int maxHealth = Health.GetMaxHealth();

        SetInitialStats(maxHealth);
    }

    protected void OnEnable()
    {
        Health.HealthChanged += OnHealthChanged;
    }

    protected void OnDisable()
    {
        Health.HealthChanged -= OnHealthChanged;
    }

    public abstract void SetInitialStats(int maxHealth);

    public abstract void OnHealthChanged(int helth);
}
