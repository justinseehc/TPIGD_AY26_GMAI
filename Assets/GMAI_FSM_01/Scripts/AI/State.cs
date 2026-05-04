using UnityEngine;

///abstracted cannot be instantiated, it serves as a base for other states. It defines the structure and common functionality for all states in the FSM.
public abstract class State
{
    protected AIController ai;
    protected Transform transform;

    public State(AIController ai)
    {
        this.ai = ai;
        this.transform = ai.transform;
    }

    public virtual void Enter() { }
    public abstract void Execute();
    public virtual void Exit() { }
}
