using UnityEngine;

using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private HFSM stateMachine;
    protected InputAction.CallbackContext InputContext;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnInput(InputAction.CallbackContext inputContext)
    {
        InputContext = inputContext;
    }
}
