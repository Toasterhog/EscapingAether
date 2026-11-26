using PlayerStates;
using UnityEngine;

namespace PlayerStates
{
    public class PlayerStateFall : State
    {
        private float MaxFallSpeed = 20f;
        public override void Process(Context ctx)
        {
            if (ctx is PlayerContext c)
            {
                if (c.GameObject.GetComponent<Rigidbody2D>().linearVelocityY < -MaxFallSpeed)
                {
                    c.GameObject.GetComponent<Rigidbody2D>().linearVelocityY = -MaxFallSpeed;
                }

                if (c.Grounded)
                {
                    c.StateMachine.ChangeState(new PlayerStateIdle());
                }
            }
            
        }

        public override void Enter(Context ctx)
        {
            if (ctx is PlayerContext c)
            {
                c.GameObject.GetComponent<Rigidbody2D>().gravityScale = 5f;
                c.GameObject.GetComponent<SpriteRenderer>().color = Color.forestGreen;
            }
        }
        public override void Exit(Context ctx)
        {
            if (ctx is PlayerContext c)
            {
                c.GameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;
            }
        }
    }
}

