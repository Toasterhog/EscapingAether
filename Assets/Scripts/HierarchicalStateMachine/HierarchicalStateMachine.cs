using UnityEngine;

public class HierarchicalStateMachine
{
    protected State CurrentState;
    protected State NextState;
    public Context Context;
    
    public void Init(Context context, State initialState)
    {
        Context = context;
        CurrentState = initialState;
        CurrentState.Enter(Context);
    }

    public void Process()
    {
        if (NextState != null)
        {
            Debug.Log(CurrentState + " change state to " + NextState );
            CurrentState.Exit(Context);
            CurrentState = NextState;
            NextState = null;
            CurrentState.Enter(Context);
        }

        if (Context == null)
        {
            Debug.Log("Context is null");
            return;
        }
        CurrentState.Process(Context);
        
    }

    public void ChangeState(State newState)
    {
        NextState = newState; 
    }
}
