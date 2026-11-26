using PlayerStates;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    
    [SerializeField] private Collider2D groundCheckCollider;
    private LayerMask groundLayer;
    private HierarchicalStateMachine stateMachine;
    private PlayerContext ctx;
    void Start()
    {
        groundLayer = LayerMask.GetMask("ground");
        stateMachine = GetComponentInChildren<HierarchicalStateMachine>();
        ctx = GetComponentInChildren<PlayerContext>();
        stateMachine.Init();
    }

    void Update()
    {
        ctx.Delta = Time.deltaTime;
        ctx.Grounded = groundCheckCollider.IsTouchingLayers(groundLayer);
        stateMachine.Process();
    }

    public void OnInput(InputAction.CallbackContext inputContext)
    {
        switch (inputContext.action.name)
        {
            case "Jump":
                if(inputContext.performed) ctx.JumpInput = true;
                if(inputContext.canceled) ctx.JumpInput = false;
                break;

        }
        //Debug.Log("Input Performed! " + inputContext);
    }
}
