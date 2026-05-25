using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFSM
{
    public abstract class State
    {
        protected HFSM fsm;
        public Action OnDone();

        public State(HFSM fsm) { this.fsm = fsm; }

        public virtual void OnEnter() { }
        public virtual void OnUpdate() { }
        public virtual void OnExit() { }

        protected void SignalDone() => OnDone?.Invoke();
    }
}

