using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonClicker : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] protected Health Health;

    protected void OnEnable()
    {
        _button.onClick.AddListener(OnClick);
    }

    protected void OnDisable()
    {
        _button.onClick.RemoveListener(OnClick);
    }

    public abstract void OnClick();
}
