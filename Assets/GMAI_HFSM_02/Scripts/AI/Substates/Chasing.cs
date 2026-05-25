using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFSM
{
    public class Chasing : State
    {
        public Chasing(HFSM fsm) : base(fsm) { }

        public override void OnEnter() => Debug.Log("Idle:Chasing started");
        public override void OnUpdate()
        {
            Debug.Log("Idle:Chasing is active.");
            if (Input.GetKeyDown(KeyCode.Space)) SignalDone();
        }

        public override void OnExit() => Debug.Log("Idle:Chasing finished.");
    }
}