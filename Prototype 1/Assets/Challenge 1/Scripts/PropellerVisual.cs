using UnityEngine;

public class PropellerVisual : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    private void FixedUpdate()
    {
        // rotate the propeller
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
