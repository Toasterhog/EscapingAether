using UnityEngine;

public class HierarchicalStateMachine
{
    protected State CurrentState;
    protected State NextState;
    public Context Context;
    
    public void Init(GameObject gameObject, State defaultState)
    {
        Context = new Context(this, gameObject);
        CurrentState = defaultState;
        CurrentState.Enter();
    }

    public void Process()
    {
        if (NextState != null)
        {
            CurrentState.Exit();
            CurrentState = NextState;
            NextState = null;
            CurrentState.Enter();
        }
        CurrentState.Process(Context);
    }

    public void ChangeState(State newState)
    {
        NextState = newState; 
    }
}
