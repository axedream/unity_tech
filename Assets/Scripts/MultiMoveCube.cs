using UnityEngine;

public class MultiMoveCube : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float _moveSpeed = 3f;
    [SerializeField] private float _rotationSpeed = 30f;

    [Header("Scale Settings")]
    [SerializeField] private float _scaleSpeed = 0.1f;
    [SerializeField] private float _maxScale = 3f;

    private Vector3 _initialScale;
    private bool _isScalingUp = true;

    private void Start()
    {
        _initialScale = transform.localScale;
    }

    private void Update()
    {
        MoveForward();
        Rotate();
        Scale();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);
    }

    void Scale()
    {
        Vector3 currentScale = transform.localScale;

        if (_isScalingUp)
        {
            currentScale += Vector3.one * _scaleSpeed * Time.deltaTime;

            if (currentScale.magnitude >= _maxScale)
                _isScalingUp = false;
        }
        else
        {
            currentScale -= Vector3.one * _scaleSpeed * Time.deltaTime;

            if (currentScale.magnitude <= _initialScale.magnitude)
                _isScalingUp = true;
        }

        transform.localScale = currentScale;
    }
}
