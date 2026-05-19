using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolState : State
{
    [Header("AI Settings")]
    public Transform target; // The Player
    public float detectionRange = 5f;
    public float moveSpeed = 2f;

    public PatrolState(AIController ai) : base(ai) { }

    public override void Enter()
    {
        Debug.Log("Patrol: Enter");
    }

    public override void Execute()
    {
    }
    
    public override void Exit()
    {
        Debug.Log("Patrol: Exit");
    }
}
