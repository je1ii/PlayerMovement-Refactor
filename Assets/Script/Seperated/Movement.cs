using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement")]
    [Tooltip("Horizontal Speed")]
    [SerializeField] private float moveSpeed;
    [Tooltip("Rate of change for move speed")]
    [SerializeField] private float acceleration;
    [Tooltip("Deceleration rate when no input is provided")]
    [SerializeField] private float deceleration;

    [Header("Controls")]
    [Tooltip("Buttons for Movement")]
    [SerializeField] private KeyCode forwardKey = KeyCode.W;
    [SerializeField] private KeyCode backwardKey = KeyCode.S;
    [SerializeField] private KeyCode leftKey = KeyCode.A;
    [SerializeField] private KeyCode rightKey = KeyCode.D;

    private Vector3 inputVector;
    private float currentSpeed;
    private CharacterController charController;
    private float initialYPosition;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }
    void Start()
    {
        initialYPosition = transform.position.y;
    }

    void Update()
    {

        HandleInput();
        Move(inputVector);
    }

    private void HandleInput()
    {
        float xinput = 0;
        float zinput = 0;
        if (Input.GetKey(forwardKey))
        {
            zinput++;
        }
        if (Input.GetKey(backwardKey))
        {
            zinput--;
        }
        if (Input.GetKey(leftKey))
        {
            xinput--;
        }
        if (Input.GetKey(rightKey))
        {
            xinput++;
        }

        inputVector = new Vector3(xinput, 0, zinput);
    }

    private void Move(Vector3 inputVector)
    {
        if (inputVector == Vector3.zero)
        {
            if (currentSpeed > 0)
            {
                currentSpeed -= deceleration * Time.deltaTime;
                currentSpeed = Mathf.Max(currentSpeed, 0);
            }
        }
        else
        {
            currentSpeed = Mathf.Lerp(currentSpeed, moveSpeed, Time.deltaTime * acceleration);
        }

        Vector3 movement = inputVector.normalized * currentSpeed * Time.deltaTime;
        charController.Move(movement);
        transform.position = new Vector3(transform.position.x, initialYPosition, transform.position.z);
    }
}
