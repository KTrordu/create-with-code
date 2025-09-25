using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    public event EventHandler OnInteractPerformed;

    private InputSystem_Actions inputActions;

    private void Awake()
    {
        Instance = this;

        inputActions = new InputSystem_Actions();
    }

    private void Start()
    {
        inputActions.Player.Enable();

        inputActions.Player.Interact.performed += Interact_performed;
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnInteractPerformed?.Invoke(this, EventArgs.Empty);
    }
}
