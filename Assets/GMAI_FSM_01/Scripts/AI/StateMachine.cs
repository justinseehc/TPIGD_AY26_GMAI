using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    private State currentState;

    public void ChangeState(State newState)
    {
        currentState?.Exit(); // It will make Exit() null if currentState is null, so we use the null-conditional operator (?.) to safely call Exit() only if currentState is not null.
        currentState = newState;
        currentState.Enter();
    }

    public void Update()
    {
        currentState?.Execute();
    }
}
