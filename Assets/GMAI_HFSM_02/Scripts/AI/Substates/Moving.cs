using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFSM
{
    public class Moving : State
    {
        public Moving(HFSM fsm) : base(fsm) { }

        public override void OnEnter() => Debug.Log("Idle:Moving started");
        public override void OnUpdate()
        {
            Debug.Log("Idle:Moving is active.");
            if (Input.GetKeyDown(KeyCode.Space)) SignalDone();
        }

        public override void OnExit() => Debug.Log("Idle:Moving finished.");
    }
}