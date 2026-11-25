using UnityEngine;

public class HFSM : MonoBehaviour
{
    protected State CurrentState;
    protected State NextState;
    protected SmContext Context;
    
    void Start()
    {
        Context = new SmContext();
    }

    void Update()
    {
        if (NextState != null)
        {
            CurrentState.Exit();
            CurrentState = NextState;
            CurrentState.Enter();
        }
        SmContext ctx = new SmContext();
    }

    public void ChangeState(State newState)
    {
        
    }
}
