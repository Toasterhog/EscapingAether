using PlayerStates;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCore : Core
{
    [SerializeField] private Collider2D groundCheckCollider;
    private LayerMask groundLayer;
    public bool JumpInput;
    public bool Grounded;
    protected override void OnStart()
    {
        groundLayer = LayerMask.GetMask("ground");
        Debug.Log("start executed on playermovement : core");
    }

   

    public void OnInput(InputAction.CallbackContext inputContext)
    {
        switch (inputContext.action.name)
        {
            case "Jump":
                if(inputContext.performed) JumpInput = true;
                if(inputContext.canceled) JumpInput = false;
                break;

        }
        //Debug.Log("Input Performed! " + inputContext);
    }
}
