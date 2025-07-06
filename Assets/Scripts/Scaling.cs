using UnityEngine;

public class ScaleCapsula : MonoBehaviour
{
    [SerializeField] private float _speedScale = 1f;

    private Vector3 _initialScale;

    private float _currentScaleFactor = 1f;

    private void Start()
    {
        _initialScale = transform.localScale;
    }

    private void Update()
    {
        _currentScaleFactor += _speedScale * Time.deltaTime;

        transform.localScale = _initialScale * _currentScaleFactor;
    }
}
