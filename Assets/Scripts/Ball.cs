using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class Ball : NetworkBehaviour
{
    [Networked] private TickTimer life { get; set; }

    public void Init()
    {
        life = TickTimer.CreateFromSeconds(Runner, 5.0f);
    }

    public override void FixedUpdateNetwork()
    {
        if (life.Expired(Runner))
        {
            // Their version of DestroyObject
            Runner.Despawn(Object);
        }
        else
        {
            transform.position += (transform.forward * 5) * Runner.DeltaTime;
        }
    }
}
