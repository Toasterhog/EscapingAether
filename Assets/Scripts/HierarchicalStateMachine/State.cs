using UnityEngine;

public abstract class State : MonoBehaviour
{
    // private Core core;
    protected State ActiveChildState;
    protected State NextState;
    protected State Parent;

    public virtual State GetInitialState() => null;
    public abstract State[] GetCildStates();
    public abstract void SetCore(Core _core);
    
    public void Init(Core _core, State parent = null)
    {
        SetCore(_core);
        Parent = parent; //?? GetComponentInParent<State>(); // ?
        foreach (State child in GetCildStates())
        {
            if(child == null) Debug.Log("Child State Not Set for " + this.GetType().Name);
            child.Init(_core, this);
        }
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