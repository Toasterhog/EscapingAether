using UnityEngine;

namespace PlayerStates
{
    public class PlayerStateRoot : PlayerState
    {
        public PlayerStateIdle idle;
        public PlayerStateJump jump;
        protected override void OnProcess()
        {
            if( Time.time % 2f < 1f)
            {
                if(ActiveChildState != jump){
                    ChangeState(jump);
                }
            }
            else
            {
                if(ActiveChildState != idle){
                    ChangeState(idle);
                }
            }
            
        }
        protected override void OnEnter()
        {
            Debug.Log("onenter root");
            core.gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
        }

        public override State GetInitialState() => idle;
        public override State[] GetCildStates()
        {
            return new State[] {idle, jump};
        }
    }
}

