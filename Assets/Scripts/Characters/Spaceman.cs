using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Characters
{
    public class Spaceman : MonoBehaviour
    {
        public GameObject idleGameObject;
        public GameObject attackGameObject;

        protected virtual void Start()
        {
            this.Idle();
        }

        public virtual void Attack()
        {
            this.idleGameObject.SetActive(false);
            this.attackGameObject.SetActive(true);
        }

        public virtual void Idle()
        {
            this.idleGameObject.SetActive(true);
            this.attackGameObject.SetActive(false);
        }
    }
}

