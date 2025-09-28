using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10.0f;
    [SerializeField] private GameObject projectilePrefab;

    private float horizontalInput;

    private void Start()
    {
        InputManager.Instance.OnThrowPerformed += InputManager_OnThrowPerformed;
    }

    private void InputManager_OnThrowPerformed(object sender, System.EventArgs e)
    {
        HandleThrow();
    }

    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if ((transform.position.x < -10 && horizontalInput < 0f) || (transform.position.x > 10 && horizontalInput > 0f))
        {
            
        }
        else transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
    }

    private void HandleThrow()
    {
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
    }
}
