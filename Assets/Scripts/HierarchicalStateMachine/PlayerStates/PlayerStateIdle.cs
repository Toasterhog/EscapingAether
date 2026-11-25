using UnityEngine;
using UnityEngine.InputSystem;

namespace PlayerStates
{
    public class PlayerStateIdle : State
    {
        public override void Process(Context ctx)
        {
            PlayerContext c = ctx as PlayerContext;
            if (c.Input.action.name == "Jump")
            {
                Debug.Log("Jump");
            }
            base.Process(ctx);
        }
    }

}

