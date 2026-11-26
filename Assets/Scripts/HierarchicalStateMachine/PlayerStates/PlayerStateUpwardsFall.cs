using UnityEngine;

namespace PlayerStates
{
    public class PlayerStateUpwardsFall : State
    {
        public override void Process(Context ctx)
        {
            if (ctx is PlayerContext c)
            {
                if (c.GameObject.GetComponent<Rigidbody2D>().linearVelocityY < 0f)
                {
                    c.StateMachine.ChangeState(new PlayerStateFall());
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
                c.GameObject.GetComponent<Rigidbody2D>().gravityScale = 4;
                c.GameObject.GetComponent<SpriteRenderer>().color = Color.limeGreen;
            }
        }
        // public override void Exit(Context ctx)
        // {
        //     if (ctx is PlayerContext c)
        //     {
        //         c.GameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;
        //     }
        // }
    }

}

