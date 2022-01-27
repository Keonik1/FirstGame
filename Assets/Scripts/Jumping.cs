using UnityEngine;

public class Jumping : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rg2d;
    [SerializeField] private float _force;

    public void Jump()
    {
        _rg2d.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
    }
}
