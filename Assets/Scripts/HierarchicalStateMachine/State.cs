using UnityEngine;
using UnityEngine.InputSystem;

public abstract class State
{
    public State ChildState;
    public virtual void Enter(){}
    public virtual void Exit(){}

    public virtual void Process(SmContext ctx)
    {
        if (ChildState != null)
        {
            ChildState.Process(ctx);
        }
    }
}

namespace PlayerStates
{
    public abstract class PlayerState : State
    {
        
    }
}
