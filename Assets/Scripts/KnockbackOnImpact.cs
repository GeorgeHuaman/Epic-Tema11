using SpatialSys.UnitySDK;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockbackOnImpact : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            SpatialBridge.actorService.localActor.avatar.AddForce(new Vector3(0f, 10f, 0f));
        }
    }
}
