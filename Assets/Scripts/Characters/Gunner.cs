using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters
{
    public class Gunner : Spaceman
    {
        public ParticleSystem bulletEffect;
        public GunnerAnimationReceiver gunnerAnimationReceiver;

        void Awake()
        {
            bulletEffect.gameObject.SetActive(false);
        }

        protected override void Start()
        {
            base.Start();
            gunnerAnimationReceiver.fireEvents += FireBullet;
        }

        public override void Attack()
        {
            base.Attack();

            // Fire a bullet
        }

        void FireBullet()
        {
            if (!bulletEffect.gameObject.activeSelf)
            {
                bulletEffect.gameObject.SetActive(true);
            }
            bulletEffect.Play();
            Idle();
        }
    }
}

