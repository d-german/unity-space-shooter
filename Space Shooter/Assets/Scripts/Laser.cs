using UnityEngine;

// ReSharper disable InconsistentNaming

public class Laser : MonoBehaviour
{
    [SerializeField] private float _speed = 8.0f;

    private void Update()
    {
        transform.Translate(Vector3.up * (_speed * Time.deltaTime));

        if (transform.position.y > 8f)
        {
            Destroy(gameObject);
        }
    }
}
