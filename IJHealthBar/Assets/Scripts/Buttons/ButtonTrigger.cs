using UnityEngine;
using UnityEngine.UI;

public abstract class ButtonTrigger : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] protected Healther _healther;

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
