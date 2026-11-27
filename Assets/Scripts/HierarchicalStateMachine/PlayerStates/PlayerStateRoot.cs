using UnityEngine;

namespace PlayerStates
{
    [RequireComponent(typeof(PlayerStateGrounded),typeof(PlayerStateAirborne))]
    public class PlayerStateRoot : PlayerState
    {
        
        public PlayerStateGrounded grounded;
        public PlayerStateAirborne airborne;
        protected override void OnProcess()
        {
            if( Time.time % 2f < 1f)
            {
                if(ActiveChildState != airborne){
                    ChangeState(airborne);
                }
            }
            else
            {
                if(ActiveChildState != grounded){
                    ChangeState(grounded);
                }
            }
            
        }
        protected override void OnEnter()
        {
            Debug.Log("onenter root");
            core.gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
        }

        public override State GetInitialState() => grounded;
        public override State[] GetCildStates()
        {
            return new State[] {grounded, airborne};
        }
    }
}

