using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFSM
{
    public class HFSM
    {
        private State currentState;
        private Idle idle;
        private Patrolling patrolling;
        private Responding responding;

        public HFSM() 
        {
            idle = new Idle(this);
            patrolling = new Patrolling(this);
            responding = new Responding(this);
        }

        public void SetState(State newState)
        {
            currentState?.OnExit();
            currentState = newState;
            currentState?.OnEnter();
        }

        public void SetIdle() => SetState(idle);
        public void SetPatrolling() => SetState(patrolling);
        public void SetResponding() => SetState(responding);
        public void Update() => currentState?.OnUpdate();
    }
}
