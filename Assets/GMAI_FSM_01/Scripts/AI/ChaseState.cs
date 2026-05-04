using UnityEngine;

public class ChaseState : State
{
    public ChaseState(AIController ai) : base(ai) { }   

    public override void Enter()
    {
        Debug.Log("Chase: Enter");
    }

    public override void Execute()
    {
        Vector3 dir = (ai.target.position - transform.position).normalized;
        transform.position += dir * ai.moveSpeed * Time.deltaTime;

        float dist = Vector3.Distance(transform.position, ai.target.position);
        if (dist > ai.detectionRange)
        {
            ai.ChangeState(new IdleState(ai));
        }
    }

    public override void Exit()
    {
        Debug.Log("Chase: Exit");
    }
}
