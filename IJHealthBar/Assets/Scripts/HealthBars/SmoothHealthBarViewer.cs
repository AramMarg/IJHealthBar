using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBarViewer : HealthBarViewer
{
    [SerializeField] private Image _fillImige;
    [SerializeField] private float _smoothDelay = 0.1f;

    private float _fillConvertCount = 100f;

    private Coroutine _coroutine;

    private void Start()
    {
        _fillImige.fillAmount = Health.GetMaxHealth() / _fillConvertCount;
    }

    public override void OnHealthChanged(int helth)
    {
        if (_coroutine != null)
        {
            StopCoroutine(_coroutine);
        }

        _coroutine = StartCoroutine(SmoothFill(helth));
    }

    private IEnumerator SmoothFill(int helth)
    {
        while (_fillImige.fillAmount != helth / _fillConvertCount)
        {
            _fillImige.fillAmount = Mathf.MoveTowards
                (_fillImige.fillAmount, helth / _fillConvertCount,
                _smoothDelay * Time.deltaTime);

            yield return null;
        }
    }
}
