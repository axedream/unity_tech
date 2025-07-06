using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection = Vector3.forward;
    [SerializeField] private float _movementSpeed = 5f;

    private int _direction = 1;
    private float _minZPosition = 0f;
    private float _maxZPosition = 10f;

    private void Update()
    {
        float currentZ = transform.position.z;

        if (_direction == 1 && currentZ >= _maxZPosition)
        {
            _direction = -1;
        }
        else if (_direction == -1 && currentZ <= _minZPosition)
        {
            _direction = 1;
        }

        transform.Translate(_movementDirection * _movementSpeed * _direction * Time.deltaTime);
    }
}