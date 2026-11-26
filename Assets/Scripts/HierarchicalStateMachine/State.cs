using UnityEngine;

public abstract class State
{
    //public State ChildState;
    
    public virtual void Enter(Context ctx){}
    public virtual void Exit(Context ctx){}

    public virtual void Process(Context ctx)
    {
        // if (ChildState != null)
        // {
        //     ChildState.Process(ctx);
        // }
    }
}


