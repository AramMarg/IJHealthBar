using UnityEngine;
using TMPro;

public class TextHealthBarViewer : HealthBarViewer
{
    [SerializeField] private TextMeshProUGUI _text;

    private int _maxHealth;

    private string _middleString = " / ";

    public override void SetInitialStats(int maxHealth)
    {
        _maxHealth = maxHealth;

        _text.text = maxHealth.ToString() + _middleString + _maxHealth.ToString();
    }

    public override void OnHealthChanged(int helth)
    {
        _text.text = helth.ToString() + _middleString + _maxHealth.ToString();
    }
}
