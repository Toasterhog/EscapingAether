using UnityEngine;
using UnityEngine.InputSystem;

public class HFSMPlayer : HFSM
{
    protected InputAction.CallbackContext InputContext;

    public void OnInput(InputAction.CallbackContext inputContext)
    {
        InputContext = inputContext;
    }
    
    void Start()
    {
        Context = new PlayerContext();
    }
    
    void Update()
    {
        PlayerContext ctx = new PlayerContext();
        ctx.Input = InputContext;
        ctx.GameObject = gameObject;
        ctx.StateMachine = this;
        ctx.Grounded = false;
        
        CurrentState.Process(ctx);
    }
}
