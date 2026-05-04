using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : State
{
    private Vector3 initialPos;
    private int patrolTimer = 0; // to keep track of how long the AI has been patrolling
    public PatrolState(AIController ai) : base(ai) { }

    public override void Enter()
    {
        Debug.Log("Patrol: Enter");
        initialPos = transform.position; // to get the initial position of the AI before patrolling
    }

    public override void Execute()
    {
        if (patrolTimer > 5)
        {
            patrolTimer = 0;
            Vector3 newPos = initialPos + new Vector3(initialPos.x - 5, initialPos.y, initialPos.z);
            if (transform.position == newPos)
            {
                newPos = initialPos + new Vector3(initialPos.x + 5, initialPos.y, initialPos.z); // to get the second position for patrolling, to move back and forth
            }

            Vector3 dir = (ai.target.position - newPos).normalized;
            transform.position += dir * ai.moveSpeed * Time.deltaTime;
        }
        else
        {
            patrolTimer++;
        }

    }

    public override void Exit()
    {
        Debug.Log("Patrol: Exit");
    }
}
