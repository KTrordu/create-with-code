using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    public event EventHandler OnThrowPerformed;
    public event EventHandler OnSpawnPerformed;

    private InputActions inputActions;

    private void Awake()
    {
        Instance = this;

        inputActions = new InputActions();
        inputActions.Player.Throw.performed += Throw_performed;
        inputActions.Player.Spawn.performed += Spawn_performed;
        inputActions.Player.Enable();
    }

    private void Spawn_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnSpawnPerformed?.Invoke(this, EventArgs.Empty);
    }

    private void Throw_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnThrowPerformed?.Invoke(this, EventArgs.Empty);
    }
}
