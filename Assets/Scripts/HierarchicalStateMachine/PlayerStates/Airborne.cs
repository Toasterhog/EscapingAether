using UnityEngine;

namespace PlayerStates
{
    
    [RequireComponent(typeof(PlayerStateJump),typeof(PlayerStateUpwardsFall),typeof(PlayerStateFall))]
    public class PlayerStateAirborne : PlayerState
    {
        public PlayerStateJump jump;
        public PlayerStateUpwardsFall upwardsFall;
        public PlayerStateFall fall;
        protected override void OnProcess()
        {
            if( Time.time % 1.2f < 0.6f)
            {
                if(ActiveChildState != jump){
                    ChangeState(jump);
                }
            }
            else
            {
                if(ActiveChildState != fall){
                    ChangeState(fall);
                }
            }
            
        }
        protected override void OnEnter()
        {
            Debug.Log("onenter root");
            core.gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
        }

        public override State GetInitialState() => fall;
        public override State[] GetCildStates()
        {
            return new State[] {jump, upwardsFall, fall};
        }
    }
}

