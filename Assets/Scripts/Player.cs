using UnityEngine;

public class Player : MonoBehaviour
{
    private IMovement _movement;
    [SerializeField] private Input _input;
    [SerializeField] private Flipping _flipping;
    [SerializeField] private Jumping _jumping;
    [SerializeField] private GroundCheck _groundCheck;

    private void Start()
    {
        _movement = GetComponent<IMovement>();
        _input.Controls.Player.Jump.performed += _ => { if (_groundCheck.Check()) _jumping.Jump(); };
    }

    private void Update()
    {
        if (_input.MovementInput > 0 && !_flipping.FacingRigth ||
            _input.MovementInput < 0 && _flipping.FacingRigth)
            _flipping.Flip();
    }

    private void FixedUpdate()
    {
        _movement.Move(_input.MovementInput);
    }
}
