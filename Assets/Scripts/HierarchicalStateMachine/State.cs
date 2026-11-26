using UnityEngine;

public abstract class State : MonoBehaviour
{
    //public State ChildState;
    public virtual void Init(){}
    public virtual void Enter(){}
    public virtual void Exit(){}

    public virtual void Process()
    {
        // if (ChildState != null)
        // {
        //     ChildState.Process(ctx);
        // }
    }
}

public abstract class PlayerState : State
{
    public PlayerContext ctx;
    public override void Init()
    {
        ctx = GetComponentInParent<PlayerContext>();
    }
}