using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SmoothHealthBarViewer : HealthBarViewer
{
    [SerializeField] private Image _fillImige;
    [SerializeField] private float _smoothDelay = 0.3f;

    private float _fillConvertCount = 100f;

    private Coroutine _coroutine;

    public override void SetInitialStats()
    {
        _fillImige.fillAmount = _healthAtStart / _fillConvertCount;
    }

    public override void OnHealthChanged(int helth)
    {
        _coroutine = StartCoroutine(SmoothFill(helth));
    }

    private IEnumerator SmoothFill(int helth)
    {
        float tempFill = 0.5f;

        for (float i = 0; i < _smoothDelay; i+= 0.1f)
        {
            //check
            print(Mathf.Lerp
                (_fillImige.fillAmount, helth / _fillConvertCount,
                tempFill));
            //end check

            _fillImige.fillAmount = Mathf.Lerp
                (_fillImige.fillAmount, helth / _fillConvertCount,
                tempFill);

            yield return null;
        }
    }
}
