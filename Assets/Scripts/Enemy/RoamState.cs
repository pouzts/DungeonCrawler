using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoamState : State
{
    private NavMeshMovement movement;
    public RoamState(StateAgent owner, string name) : base(owner, name)
    {
    }

    public override void OnEnter()
    {
        Quaternion rotation = Quaternion.AngleAxis(Random.Range(-180, 180), Vector3.up);
        Vector3 forward = rotation * Vector3.forward;
        Vector3 destination = owner.transform.position + forward * Random.Range(-10f, 15f); // could be wrong
            
        owner.movement.MoveTowards(destination);
        owner.movement.Resume();
        owner.atDestination.value = false;
    }

    public override void OnExit()
    {
    }

    public override void OnUpdate()
    {
        if (owner.movement.destination.magnitude - owner.transform.position.magnitude <= 1.5f) //< get distance between owner position and movement destination > <= 1.5
        {
            owner.atDestination.value = true;
        }
    }
}
