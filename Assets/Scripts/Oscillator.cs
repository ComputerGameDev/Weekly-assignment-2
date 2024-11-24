using UnityEngine;

public class Pendulum : MonoBehaviour
{
    public float amplitude = 45f;
    public float speed = 1f;

    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = transform.rotation;
    }

    void Update()
    {
        float angle = amplitude * Mathf.Sin(speed * Time.time);
        transform.rotation = initialRotation * Quaternion.Euler(0f, 0f, angle);
    }
}