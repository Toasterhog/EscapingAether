using UnityEngine;

namespace PlayerStates
{
    public class PlayerStateUpwardsFall : PlayerState
    {
        protected override void OnProcess()
        {
            if (core.gameObject.GetComponent<Rigidbody2D>().linearVelocityY < 0f)
            {
                Parent.ChangeState(((PlayerStateAirborne)Parent).fall);
            }
        
            if (core.Grounded)
            {
                //core.StateMachine.ChangeState(new PlayerStateIdle());
            }
            
        }

        protected override void OnEnter()
        {
            core.gameObject.GetComponent<Rigidbody2D>().gravityScale = 4;
            core.gameObject.GetComponent<SpriteRenderer>().color = Color.limeGreen;
        }
        // public override void Exit(Context ctx)
        // {
        //     if (ctx is PlayerContext c)
        //     {
        //         c.GameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;
        //     }
        // }
        protected override void OnExit()
        {
            core.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;
        }
        public override State[] GetCildStates()
        {
            return new State[] {};
        }
    }

}

