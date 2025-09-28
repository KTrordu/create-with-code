using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    public event EventHandler OnThrowPerformed;

    private InputActions inputActions;

    private void Awake()
    {
        Instance = this;

        inputActions = new InputActions();
        inputActions.Player.Throw.performed += Throw_performed;
        inputActions.Player.Enable();
    }

    private void Throw_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnThrowPerformed?.Invoke(this, EventArgs.Empty);
    }
}
