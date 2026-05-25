using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFSM
{
    public class Patrolling : State
    {
        private State moving;
        private State alert;
        private State substate;

        public Patrolling(HFSM fsm) : base(fsm)
        {
            moving = new Moving(fsm);
            alert = new Alert(fsm);
            moving.OnDone += HandleSubstateDone;
            alert.OnDone += HandleSubstateDone;
        }

        public override void OnEnter()
        {
            Debug.Log("Guard starts patrolling");
            SetSubstate(moving);
        }

        public override void OnUpdate()
        {
            substate?.OnUpdate();

            if (Input.GetKeyDown(KeyCode.I)) fsm.SetIdle();
            if (Input.GetKeyDown(KeyCode.R)) fsm.SetResponding();
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
            if ((newSubstate is Moving && substate is Moving) || (newSubstate is Alert && substate is Alert)) return;

            substate?.OnExit();
            substate = newSubstate;
            substate?.OnEnter();
        }
    }
}
