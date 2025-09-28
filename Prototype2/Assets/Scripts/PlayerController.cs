using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10.0f;

    private float horizontalInput;

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if ((transform.position.x < -10 && horizontalInput < 0f) || (transform.position.x > 10 && horizontalInput > 0f))
        {
            
        }
        else transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
    }
}
