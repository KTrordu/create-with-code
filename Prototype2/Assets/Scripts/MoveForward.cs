using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float throwSpeed = 40.0f;

    private void Update()
    {
        transform.Translate(Vector3.forward * throwSpeed * Time.deltaTime);
    }
}
