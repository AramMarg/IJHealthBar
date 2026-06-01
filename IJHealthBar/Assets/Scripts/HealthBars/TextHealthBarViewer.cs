using UnityEngine;
using TMPro;

public class TextHealthBarViewer : HealthBarViewer
{
    [SerializeField] private TextMeshProUGUI _text;

    private string _postfix = " / 100";

    public override void SetInitialStats()
    {
        _text.text = _healthAtStart.ToString() + _postfix;
    }

    public override void OnHealthChanged(int _helth)
    {
        _text.text = _helth.ToString() + _postfix;
    }
}
