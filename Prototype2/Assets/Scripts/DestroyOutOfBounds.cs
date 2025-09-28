using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBounds = 30.0f;
    [SerializeField] private float lowBounds = -10.0f;

    private void Update()
    {
        if (transform.position.z > topBounds || transform.position.z < lowBounds) Destroy(gameObject);
    }
}
