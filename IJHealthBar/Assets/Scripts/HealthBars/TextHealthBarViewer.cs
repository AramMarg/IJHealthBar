using UnityEngine;
using TMPro;

public class TextHealthBarViewer : HealthBarViewer
{
    [SerializeField] private TextMeshProUGUI _text;

    private int _maxHealth;

    private string _middleString = " / ";

    private void Start()
    {
        _maxHealth = Health.GetMaxHealth();

        _text.text = _maxHealth.ToString() + _middleString + _maxHealth.ToString();
    }

    public override void OnHealthChanged(int helth)
    {
        _text.text = helth.ToString() + _middleString + _maxHealth.ToString();
    }
}
