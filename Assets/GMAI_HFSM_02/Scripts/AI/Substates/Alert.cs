using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFSM
{
    public class Alert : State
    {
        public Alert(HFSM fsm) : base(fsm) { }

        public override void OnEnter() => Debug.Log("Idle:Alert started");
        public override void OnUpdate()
        {
            Debug.Log("Idle:Alert is active.");
            if (Input.GetKeyDown(KeyCode.Space)) SignalDone();
        }

        public override void OnExit() => Debug.Log("Idle:Alert finished.");
    }
}