using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFSM
{
    public class Resting : State
    {
        public Resting(HFSM fsm) : base(fsm) { }

        public override void OnEnter() => Debug.Log("Idle:Resting started");
        public override void OnUpdate()
        {
            Debug.Log("Idle:Resting is active.");
            if (Input.GetKeyDown(KeyCode.Space)) SignalDone();
        }

        public override void OnExit() => Debug.Log("Idle:Resting finished.");
    }
}