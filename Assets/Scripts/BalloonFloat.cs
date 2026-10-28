using UnityEngine;

public class BalloonFloat : MonoBehaviour
{
    public float amplitude = 0.05f;
    public float speed = 1.5f;
    public float sway = 5f;

    Vector3 startPos;
    float offset;

    void Start()
    {
        startPos = transform.localPosition;
        offset = Random.Range(0f, 6.28f);
    }

    void Update()
    {
        float t = Time.time * speed + offset;
        transform.localPosition = startPos + new Vector3(0f, Mathf.Sin(t) * amplitude, 0f);
        transform.localRotation = Quaternion.Euler(0f, 0f, Mathf.Sin(t * 0.7f) * sway);
    }
}