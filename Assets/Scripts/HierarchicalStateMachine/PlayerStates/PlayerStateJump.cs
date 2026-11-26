using UnityEngine;

namespace PlayerStates
{
    public class PlayerStateJump : PlayerState
    {
        private float jumpForce = 3f;
        // protected override void OnProcess()
        // {
        //     if(core.JumpInput)
        //     {
        //         if (core.JumpInput == false)
        //         {
        //             Parent.ChangeState((PlayerStateAirborne)new PlayerStateUpwardsFall());
        //         }
        //         if (core.gameObject.GetComponent<Rigidbody2D>().linearVelocityY < 0f)
        //         {
        //             core.StateMachine.ChangeState(new PlayerStateFall());
        //         }
        //         // if (c.Grounded)
        //         // {
        //         //     c.StateMachine.ChangeState(new PlayerStateIdle());
        //         // }
        //     }
        //     
        // }

        protected override void OnEnter()
        {
            
            core.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1.5f;
            core.gameObject.GetComponent<Rigidbody2D>().linearVelocityY = jumpForce;
            core.gameObject.GetComponent<SpriteRenderer>().color = Color.darkSeaGreen;
            
        }
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

