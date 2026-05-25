using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFSM
{
    public class Responding : State
    {
        private State moving;
        private State alert;
        private State substate;

        public Responding(HFSM fsm) : base(fsm)
        {
        }

        public override void OnEnter()
        {
            Debug.Log("Guard responding to alert");
            SetSubstate(moving);
        }

        public override void OnUpdate()
        {
            substate?.OnUpdate();
        }

        public override void OnExit()
        {
            substate?.OnExit();
        }

        private void HandleSubstateDone()
        {
            SetSubstate(Random.value > 0.5f ? moving : alert);
        }

        private void SetSubstate(State newSubstate)
        {
            substate?.OnExit();
            substate = newSubstate;
            substate?.OnEnter();
        }
    }
}
