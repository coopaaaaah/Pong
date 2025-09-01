
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Rigidbody2D player;
    private InputAction _moveAction;
    private readonly int _moveSpeed = 5;
    void Start()
    {
        _moveAction = InputSystem.actions.FindAction("Move");
    }

    void Update()
    {
        if (_moveAction.inProgress && _isUpDownAction(_moveAction))
        {
            Vector2 direction = _moveAction.ReadValue<Vector2>();
            player.linearVelocity = direction.normalized * _moveSpeed;
        }
        else
        {
            player.linearVelocity = Vector2.zero;
        }
    }

    private bool _isUpDownAction(InputAction moveAction)
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        return direction.normalized == new Vector2(0, 1f).normalized || direction.normalized == new Vector2(0, -1f).normalized;
    }

}
