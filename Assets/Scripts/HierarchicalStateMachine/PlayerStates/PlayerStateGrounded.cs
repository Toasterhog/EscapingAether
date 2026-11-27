using UnityEngine;

namespace PlayerStates
{
    [RequireComponent(typeof(PlayerStateIdle))]
    public class PlayerStateGrounded : PlayerState
    {
        public PlayerStateIdle idle;
        protected override void OnProcess()
        {
            
            
        }
        protected override void OnEnter()
        {
            Debug.Log("onenter root");
            core.gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
        }

        public override State GetInitialState() => idle;
        public override State[] GetCildStates()
        {
            return new State[] {idle};
        }
    }
}

