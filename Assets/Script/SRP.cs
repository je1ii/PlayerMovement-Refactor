using System.Runtime.CompilerServices;
using UnityEngine;

public class SRP : MonoBehaviour
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

    [Header("Effects")]
    [SerializeField] private ParticleSystem partSys;

    [Header("Collision")]
    [SerializeField] private LayerMask layerMask;

    [Header("Audio")]
    [SerializeField] private AudioSource audioSource;

    private Vector3 inputVector;
    private float currentSpeed;
    private CharacterController charController;
    private float initialYPosition;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
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

        inputVector = new Vector3 (xinput, 0, zinput);
    }

    private void Move(Vector3 inputVector)
    {
        if(inputVector == Vector3.zero)
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

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //check if collided object's layer is in the chosen layer mask
        if((layerMask.value & (1 << hit.gameObject.layer)) > 0)
        {
            PlayFX();
            PlayAudio();
        }
    }

    private void PlayFX()
    {
        partSys.Play();
    }

    private void PlayAudio()
    {
        audioSource.Play();
    }
}
