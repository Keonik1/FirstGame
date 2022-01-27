using UnityEngine;

public class PhysicsMovement : MonoBehaviour, IMovement
{
    [SerializeField] private Rigidbody2D _rg2d;
    [SerializeField] private float _speed;

    public void Move(float direction)
    {
        _rg2d.velocity = new Vector2(direction * _speed * Time.fixedDeltaTime, _rg2d.velocity.y);
    }
}
