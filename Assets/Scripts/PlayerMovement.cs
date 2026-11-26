using PlayerStates;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Collider2D groundCheckCollider;
    private LayerMask groundLayer;
    private HierarchicalStateMachine stateMachine;
    void Start()
    {
        groundLayer = LayerMask.GetMask("ground");
        stateMachine = new HierarchicalStateMachine();
        Context context = new PlayerContext(stateMachine, gameObject);
        stateMachine.Init(context, new PlayerStateIdle());
    }

    void Update()
    {
        PlayerContext c = stateMachine.Context as PlayerContext;
        c.Delta = Time.deltaTime;
        c.Grounded = groundCheckCollider.IsTouchingLayers(groundLayer);
        stateMachine.Process();
    }

    public void OnInput(InputAction.CallbackContext inputContext)
    {
        switch (inputContext.action.name)
        {
            case "Jump":
                if(inputContext.performed) (stateMachine.Context as PlayerContext).JumpInput = true;
                if(inputContext.canceled) (stateMachine.Context as PlayerContext).JumpInput = false;
                break;

        }
        //Debug.Log("Input Performed! " + inputContext);
    }
}
