using UnityEngine;
using UnityEngine.UI;

public class NormalHealthBarViewer : HealthBarViewer
{
    [SerializeField] private Image _fillImige;

    private float _fillConvertCount = 100f;

    public override void SetInitialStats()
    {
        _fillImige.fillAmount = _healthAtStart / _fillConvertCount;
    }

    public override void OnHealthChanged(int helth)
    {
        _fillImige.fillAmount = helth / _fillConvertCount;
    }
}
