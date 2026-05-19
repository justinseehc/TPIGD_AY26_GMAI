using UnityEngine;

public class ChaseState : State
{
    public ChaseState(AIController ai) : base(ai) { }   

    public override void Enter()
    {
        ai.animator.SetBool("Run", true);
        Debug.Log("Chase: Enter");
    }

    public override void Execute()
    {
        Vector3 dir = (ai.target.position - transform.position).normalized;
        transform.position += dir * ai.moveSpeed * Time.deltaTime;
        transform.LookAt(ai.target.position);
        float dist = Vector3.Distance(transform.position, ai.target.position);

        if (dist > ai.detectionRange)
        {
            ai.ChangeState(new IdleState(ai));
        }
    }

    public override void Exit()
    {
        ai.animator.SetBool("Run", false);
        Debug.Log("Chase: Exit");
    }
}
