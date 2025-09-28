using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBounds = 30.0f;
    [SerializeField] private float lowBounds = -10.0f;

    private void Update()
    {
        if (transform.position.z > topBounds) Destroy(gameObject);
        else if (transform.position.z < lowBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
