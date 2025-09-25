using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 cam1Offset;
    [SerializeField] private Vector3 cam2Offset;

    private bool isCamChanged = false;
    private Vector3 offset;

    private void Awake()
    {
        offset = cam1Offset;
    }

    private void Start()
    {
        InputManager.Instance.OnInteractPerformed += Instance_OnInteractPerformed;
    }

    private void Instance_OnInteractPerformed(object sender, System.EventArgs e)
    {
        HandleChangeCamera();
        Debug.Log("interact");
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    private void HandleChangeCamera()
    {
        if (!isCamChanged)
        {
            offset = cam2Offset;
            isCamChanged = true;
        }
        else
        {
            offset = cam1Offset;
            isCamChanged = false;
        }
    }
}
