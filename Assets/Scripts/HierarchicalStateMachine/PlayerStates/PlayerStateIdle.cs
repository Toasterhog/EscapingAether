using UnityEngine;

namespace PlayerStates
{
    public class PlayerStateIdle : State
    {
        public override void Process(Context ctx)
        {
            if (ctx is PlayerContext c)
            {
                if (c.JumpInput)
                {
                    c.StateMachine.ChangeState(new PlayerStateJump());
                }
            }
            
        }
        public override void Enter(Context ctx)
        {
            if (ctx is PlayerContext c)
            {
                c.GameObject.GetComponent<SpriteRenderer>().color = Color.blue;
            }
        }
    }
}

