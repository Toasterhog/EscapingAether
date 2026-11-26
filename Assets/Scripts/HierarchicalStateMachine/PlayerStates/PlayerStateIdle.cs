using System;
using UnityEngine;

namespace PlayerStates
{
    public class PlayerStateIdle : PlayerState
    {
        protected override void OnProcess()
        {
            if (core.JumpInput)
            {
                Parent.ChangeState( ((PlayerStateRoot)Parent).idle);
            }
            
        }
        protected override void OnEnter()
        {
            Debug.Log("onenter idle");
            core.gameObject.GetComponent<SpriteRenderer>().color = Color.dodgerBlue;
        }

        public override State[] GetCildStates()
        {
            return Array.Empty<State>();
        }
    }
}

