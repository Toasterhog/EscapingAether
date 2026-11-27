using PlayerStates;
using UnityEngine;

namespace PlayerStates
{
    public class PlayerStateFall : PlayerState
    {
        private float MaxFallSpeed = 20f;
        protected override void OnProcess()
        {
            if (core.gameObject.GetComponent<Rigidbody2D>().linearVelocityY < -MaxFallSpeed)
            {
                core.gameObject.GetComponent<Rigidbody2D>().linearVelocityY = -MaxFallSpeed;
            }

            if (core.Grounded)
            {
                //Parent.ChangeState((Parent.Parent));
            }
            
        }
        protected override void OnEnter()
        {
            core.gameObject.GetComponent<Rigidbody2D>().gravityScale = 5f;
            core.gameObject.GetComponent<SpriteRenderer>().color = Color.forestGreen;
        }
        protected override void OnExit()
        {
            core.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;
        }

        public override State GetInitialState() => null;
        public override State[] GetCildStates()
        {
            return new State[] {};
        }
    }
}

