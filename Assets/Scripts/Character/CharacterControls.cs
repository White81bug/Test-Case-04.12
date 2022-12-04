using UnityEngine;

public class CharacterControls : MonoBehaviour
{
    
    public Controls Controls;
    private CharacterController _controller;
    [Header("Character movement speed")]
    [SerializeField] private float speed;
    [Header("How smooth character turn is")]
    [SerializeField] private float turnSmoothTime = 0.1f;
    [Header("Mouse Cursor Settings")]
    [SerializeField] private bool cursorLocked = true;

    [Header(("Gravity"))] [SerializeField] private Vector3 gravity = new(0f, -9.8f, 0f);
    private float _turnSmoothVelocity;
    private Transform _camera;
    private Vector3 _velocity;
    
    private void Awake()
    {
        //Setting up essentials;
        _controller = GetComponent<CharacterController>();
        Controls = new Controls();
        Controls.PlayerInGame.Enable();
        if (Camera.main != null) _camera = Camera.main.transform;
    }
    private void FixedUpdate()
    {
        //Reading controls & moving player
        Vector2 inputVector = Controls.PlayerInGame.Movement.ReadValue<Vector2>();
        Vector3 direction = new Vector3(inputVector.x, 0f, inputVector.y).normalized;
        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + _camera.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _turnSmoothVelocity,
                turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDir = Quaternion.Euler(0f, angle, 0f) * Vector3.forward;
            _controller.Move(moveDir * (speed * Time.deltaTime) + gravity);
        }
        
    }
    
    //Locking cursor
    private void OnApplicationFocus(bool hasFocus)
    {
        SetCursorState(cursorLocked);
    }
    private void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
    }
}
