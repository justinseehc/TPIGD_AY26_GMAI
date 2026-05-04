using UnityEngine;

public class IdleState : State
{
    public IdleState(AIController ai): base(ai) { }

    public override void Enter()
    {
        Debug.Log("Idle: Enter");
    }

    public override void Execute()
    {
        float dist = Vector3.Distance(transform.position, ai.target.position);
        if (dist < ai.detectionRange)
        {
            ai.ChangeState(new ChaseState(ai));
        }
    }

    public override void Exit()
    {
        Debug.Log("Idle: Exit");
    }
}
