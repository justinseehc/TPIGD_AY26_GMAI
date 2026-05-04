using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    private StateMachine stateMachine;

    [Header("AI Settings")]
    public Transform target;
    public float detectionRange = 10f;
    public float moveSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        stateMachine = new StateMachine();
        stateMachine.ChangeState(new IdleState(this));
    }

    // Update is called once per frame
    void Update()
    {
        stateMachine.Update();
    }

    public void ChangeState(State newState)
    {
        stateMachine.ChangeState(newState);
    }
}
