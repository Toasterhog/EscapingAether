using UnityEngine;

namespace PlayerStates
{
    public class PlayerStateIdle : PlayerState
    {
        public override void Process()
        {
            if (ctx.JumpInput)
            {
                //ctx.StateMachine.ChangeState(new PlayerStateJump());
            }
            
        }
        public override void Enter()
        {
            ctx.GameObject.GetComponent<SpriteRenderer>().color = Color.dodgerBlue;
        }
    }
}

