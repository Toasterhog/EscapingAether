using PlayerStates;
using UnityEngine;

using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private HierarchicalStateMachine stateMachine;
    protected InputAction.CallbackContext InputContext;
    void Start()
    {
        stateMachine = new HierarchicalStateMachine();
        stateMachine.Init(gameObject, new PlayerStateIdle());
    }

    void Update()
    {
        PlayerContext c = stateMachine.Context as PlayerContext;
        c.Delta = Time.deltaTime;
        c.Input = InputContext;
        stateMachine.Process();
    }

    public void OnInput(InputAction.CallbackContext inputContext)
    {
        InputContext = inputContext;
        Debug.logger.Log("OnInput " + InputContext);
    }
}
