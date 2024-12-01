using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public EnemyConfig enemyConfig;
    public EnemyStateMachine stateMachine;
    
    private void Start()
    {
        stateMachine.ChangeState(new FallFromSkyState(stateMachine, Vector3.zero));
    }
}