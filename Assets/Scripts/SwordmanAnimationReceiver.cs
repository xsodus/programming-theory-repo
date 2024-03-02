using UnityEngine;
using System;

public class SwordmanAnimationReceiver : MonoBehaviour
{
    public Action slashEvents;

    void SlashEnded ()
    {
        if(slashEvents != null)
        {
            slashEvents();
        }
    }
}
