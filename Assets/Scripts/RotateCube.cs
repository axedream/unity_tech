using Unity.Collections;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Rotate(0, _speed * Time.deltaTime, 0);
    }
}
