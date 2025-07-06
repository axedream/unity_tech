using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection = Vector3.forward;
    [SerializeField] private float _movementSpeed = 5f;

    private void Update()
    {
        float currentZ = transform.position.z;

        transform.Translate(_movementDirection * _movementSpeed * Time.deltaTime);
    }
}