using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HFSM
{
    public class AIController : MonoBehaviour
    {
        private HFSM stateMachine;

        private void Start()
        {
            stateMachine = new HFSM();
            stateMachine.SetIdle();
        }

        private void Update()
        {
            stateMachine.Update();
        }
    }
}