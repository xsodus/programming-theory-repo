using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunnerAnimationReceiver : MonoBehaviour
{
    public Action fireEvents;

    void FireBullet ()
    {
        if(fireEvents != null)
        {
            fireEvents();
        }
    }
}
