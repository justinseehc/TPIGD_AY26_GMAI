using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFSM
{
    public class LookingAround : State
    {
        public LookingAround(HFSM fsm) : base(fsm) { }

        public override void OnEnter() => Debug.Log("Idle:LookingAround started");
        public override void OnUpdate()
        {
            Debug.Log("Idle:LookingAround is active.");
            if (Input.GetKeyDown(KeyCode.Space)) SignalDone();
        }

        public override void OnExit() => Debug.Log("Idle:LookingAround finished.");
    }
}