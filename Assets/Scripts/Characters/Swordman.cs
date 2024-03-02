using UnityEngine;
using Characters;

namespace Characters {

    public class Swordman : Spaceman
    {
        public SwordmanAnimationReceiver swordmanAnimationReceiver;

        // Use this for initialization
        protected override void Start()
        {
            base.Start();
            swordmanAnimationReceiver.slashEvents += SlashEnded;
        }

        void SlashEnded()
        {
            Idle();
        }
    }

}
