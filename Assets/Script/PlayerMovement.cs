using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float targetSpeed;
    public float walkSpeed;
    public float runSpeed;

    public Vector2 moveInput;
    public Animator animator;
    public CharacterController characterController;
    public PlayerControl playerControl;

    public bool isRunning;

    private void OnEnable()
    {
        playerControl = new PlayerControl();
        playerControl.PlayerActionMap.PlayerActionGlobal.performed += PlayerActionGlobal_performed;
        playerControl.PlayerActionMap.PlayerActionGlobal.canceled += PlayerActionGlobal_canceled;
        playerControl.PlayerActionMap.Jump.performed += Jump_performed;
        playerControl.PlayerActionMap.Sprint.performed += Sprint_performed;
        playerControl.Enable();
    }

    private void Sprint_performed(InputAction.CallbackContext obj)
    {
        if (obj.performed)
        {
            isRunning = true;
        }
    }

    private void Jump_performed(InputAction.CallbackContext obj)
    {
        if (obj.performed) 
        { 
            // insert logic of jumping mechanics in character controller
        }
    }

    private void OnDisable()
    {
        playerControl.Disable();
    }

    private void PlayerActionGlobal_canceled(InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    private void PlayerActionGlobal_performed(InputAction.CallbackContext obj)
    {
        moveInput = obj.ReadValue<Vector2>();
    }

    void Awake()
    {
        characterController = GetComponent<CharacterController>(); 
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector3 moveDirection = new Vector3(moveInput.x, 0,moveInput.y);
        moveDirection = transform.TransformDirection(moveDirection) * targetSpeed;
        animator.SetFloat("Speed", moveInput.magnitude);
        characterController.Move(moveDirection* Time.deltaTime);
    }
}
