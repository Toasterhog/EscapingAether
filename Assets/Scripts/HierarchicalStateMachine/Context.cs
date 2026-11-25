using UnityEngine;
using UnityEngine.InputSystem;

public class SmContext
{
    public HFSM StateMachine;
    public GameObject GameObject;
    public float TimeSinceEnterState;
}

public class PlayerContext : SmContext
{
    public InputAction.CallbackContext Input;
    public bool Grounded;

}