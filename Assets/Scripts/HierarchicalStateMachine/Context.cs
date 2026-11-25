using UnityEngine;
using UnityEngine.InputSystem;

public class Context
{
    public Context(HierarchicalStateMachine sm, GameObject gameObject)
    {
        this.StateMachine = sm;
        this.GameObject = gameObject;
    }
    public readonly HierarchicalStateMachine StateMachine;
    public readonly GameObject GameObject;
    public float Delta;
}

public class PlayerContext : Context
{
    public PlayerContext(HierarchicalStateMachine sm, GameObject gameObject) : base(sm, gameObject){}
    
    public InputAction.CallbackContext Input;
    public bool Grounded;

}