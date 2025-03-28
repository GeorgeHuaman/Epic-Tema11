using SpatialSys.UnitySDK;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockbackOnImpact : MonoBehaviour
{

    public void KnockBack()
    {
        SpatialBridge.actorService.localActor.avatar.AddForce(new Vector3(0f, 10f, 0f));
    }

    public void Jump()
    {
        SpatialBridge.actorService.localActor.avatar.AddForce(new Vector3(0f, 25f, 0f));
    }
}
