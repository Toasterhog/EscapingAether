using UnityEngine;

public abstract class State : MonoBehaviour
{
    // private Core core;
    protected State ActiveChildState;
    protected State NextState;
    //protected State Parent;

    public State GetInitialState() => null;
    public abstract void SetCore(Core _core);
    
    public virtual void Init(Core _core)
    {
        SetCore(_core);
    }

    public void Enter()
    {
        OnEnter();
        ActiveChildState = GetInitialState();
        ActiveChildState?.Enter();
    }

    public void Exit()
    {
        ActiveChildState?.Exit();
        OnExit();
        
    }

    public void Process()
    {
        if (NextState != null)
        {
            Debug.Log(ActiveChildState + " change state to " + NextState );
            ActiveChildState?.Exit();
            ActiveChildState = NextState;
            NextState = null;
            ActiveChildState.Enter();
        }

        OnProcess();
        ActiveChildState?.Process();
    }

    public void ChangeState(State newState)
    {
        NextState = newState; 
    }
    
    //protected virtual void OnInit(){}
    protected virtual void OnEnter(){}
    protected virtual void OnExit(){}
    protected virtual void OnProcess(){ }
    
}

public abstract class PlayerState : State
{
    protected PlayerCore core;
    public override void SetCore(Core _core) => core ??= (PlayerCore)_core;
}