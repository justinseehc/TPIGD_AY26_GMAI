using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFSM
{
    public class Investigating : State
    {
        public Investigating(HFSM fsm) : base(fsm) { }

        public override void OnEnter() => Debug.Log("Idle:Investigating started");
        public override void OnUpdate()
        {
            Debug.Log("Idle:Investigating is active.");
            if (Input.GetKeyDown(KeyCode.Space)) SignalDone();
        }

        public override void OnExit() => Debug.Log("Idle:Investigating finished.");
    }
}