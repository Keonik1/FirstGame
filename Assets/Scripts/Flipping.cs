
using UnityEngine;

public class Flipping : MonoBehaviour
{
    [SerializeField] private bool _facingRigth;

    public bool FacingRigth { get => _facingRigth; set => _facingRigth = value; }

    public void Flip()
    {
        _facingRigth = !_facingRigth;
        transform.Rotate(0, 180, 0);
    }
}
