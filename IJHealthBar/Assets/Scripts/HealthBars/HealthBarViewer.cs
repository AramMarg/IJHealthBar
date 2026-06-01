using UnityEngine;

public abstract class HealthBarViewer : MonoBehaviour
{
    [SerializeField] protected Healther _healther;

    protected int _healthAtStart = 100;

    protected void Awake()
    {
        SetInitialStats();
    }

    protected void OnEnable()
    {
        _healther.HealthChanged += OnHealthChanged;
    }

    protected void OnDisable()
    {
        _healther.HealthChanged -= OnHealthChanged;
    }

    public abstract void SetInitialStats();

    public abstract void OnHealthChanged(int helth);
}
