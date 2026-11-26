// using UnityEngine;
//
// namespace PlayerStates
// {
//     public class PlayerStateJump : State
//     {
//         private float jumpForce = 6f;
//         public override void Process(Context ctx)
//         {
//             if (ctx is PlayerContext c)
//             {
//                 if (c.JumpInput == false)
//                 {
//                     c.StateMachine.ChangeState(new PlayerStateUpwardsFall());
//                 }
//                 if (c.GameObject.GetComponent<Rigidbody2D>().linearVelocityY < 0f)
//                 {
//                     c.StateMachine.ChangeState(new PlayerStateFall());
//                 }
//                 // if (c.Grounded)
//                 // {
//                 //     c.StateMachine.ChangeState(new PlayerStateIdle());
//                 // }
//             }
//             
//         }
//
//         public override void Enter(Context ctx)
//         {
//             if (ctx is PlayerContext c)
//             {
//                 c.GameObject.GetComponent<Rigidbody2D>().gravityScale = 0.5f;
//                 c.GameObject.GetComponent<Rigidbody2D>().linearVelocityY = jumpForce;
//                 c.GameObject.GetComponent<SpriteRenderer>().color = Color.darkSeaGreen;
//             }
//         }
//         public override void Exit(Context ctx)
//         {
//             if (ctx is PlayerContext c)
//             {
//                 c.GameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;
//             }
//         }
//     }
//
// }
//
