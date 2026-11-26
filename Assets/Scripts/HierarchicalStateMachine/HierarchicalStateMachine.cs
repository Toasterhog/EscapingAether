// using System.Collections.Generic;
// using UnityEngine;
//
// public class HierarchicalStateMachine : MonoBehaviour
// {
//     [SerializeField] private List<State> StateList;
//     protected State CurrentState;
//     protected State NextState;
//     
//     public void Init()
//     {
//         foreach (State state in StateList)
//         {
//             state.Init();
//         }
//         CurrentState = StateList[0];
//         CurrentState.Enter();
//     }
//
//     public void Process()
//     {
//         if (NextState != null)
//         {
//             Debug.Log(CurrentState + " change state to " + NextState );
//             CurrentState.Exit();
//             CurrentState = NextState;
//             NextState = null;
//             CurrentState.Enter();
//         }
//         
//         CurrentState.Process();
//         
//     }
//
//     public void ChangeState(State newState)
//     {
//         NextState = newState; 
//     }
// }
