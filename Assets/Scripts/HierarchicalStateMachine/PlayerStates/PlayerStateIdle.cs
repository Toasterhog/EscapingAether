using UnityEngine;

namespace PlayerStates
{
    public class PlayerStateIdle : PlayerState
    {
        protected override void OnProcess()
        {
            if (core.JumpInput)
            {
                //ctx.StateMachine.ChangeState(new PlayerStateJump());
            }
            
        }
        protected override void OnEnter()
        {
            Debug.Log("onenter idle, core: " + core);
            core.gameObject.GetComponent<SpriteRenderer>().color = Color.dodgerBlue;
        }
        
    }
}

