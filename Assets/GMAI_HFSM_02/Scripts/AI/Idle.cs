using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFSM 
{
    public class Idle : State
    {
        private State resting;
        private State lookingAround;
        private State substate;

        public Idle(HFSM fsm) : base(fsm)
        {
            resting = new Resting(fsm);
            lookingAround = new LookingArround(fsm);
            resting.OnDone() += HandleSubstateDone;
            lookingAround.OnDone() += HandleSubstateDone;
        }

        public override void OnEnter()
        {
            Debug.Log("Guard is awake and idling");
            SetSubstate(resting);
        }

        public override void OnUpdate()
        {
            substate?.OnUpdate();
            if (Input.GetKeyDown(KeyCode.P)) fsm.SetPatrolling();
        }

        public override void OnExit()
        {
            substate?.OnExit();
            base.OnExit();
        }

        private void HandleSustateDone()
        {
            SetSubstate(Random.value > 0.5f ? resting : lookingAround);
        }

        private void SetSubstate(State newSub)
        {
            substate?.OnExit();
            substate = newSub;
            substate?.OnEnter();
        }
    }
}