using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    PlayerInput playerInput;
    InputAction moveAction;
    Animator animator;


    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        moveAction = playerInput.actions.FindAction("Move");
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }
    void movePlayer()
    {
        Vector2 derection = moveAction.ReadValue<Vector2>();
        Vector3 move = new Vector3(derection.x, 0, derection.y);

        transform.position += move * speed * Time.deltaTime;

        if(animator != null)
        {
            animator.SetFloat("Speed",move.magnitude);
        }

        if(move != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(move);

            transform.rotation = Quaternion.Slerp(
                transform.rotation, targetRotation, 
                Time.deltaTime * 10f);

        }
    }
}
