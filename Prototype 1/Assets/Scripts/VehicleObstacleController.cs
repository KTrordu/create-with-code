using UnityEngine;

public class VehicleObstacleController : MonoBehaviour
{
    [SerializeField] private float speed = 20.0f;

    private void Update()
    {
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
