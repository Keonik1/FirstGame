
using UnityEngine;

public class Input : MonoBehaviour
{
    private Controls _controls;
    private float _movementInput;

    public Controls Controls { get => _controls; }
    public float MovementInput { get => _movementInput; }

    private void Awake() { _controls = new Controls(); }
    private void OnDisable() { _controls.Disable(); }
    private void OnEnable() { _controls.Enable(); }

    private void Update()
    {
        _movementInput = _controls.Player.Movement.ReadValue<float>();
    }

}
