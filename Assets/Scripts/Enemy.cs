using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Archer
{

    public class Enemy : MonoBehaviour, IScoreProvider
    {

        // Cu�ntas vidas tiene el enemigo
        [SerializeField]
        private int hitPoints;
        
        private float timerAfterKill = 3.0f;
        private float timeOfKill;

        [SerializeField]
        GameObject temporalLight;

        private Animator animator;

        public event IScoreProvider.ScoreAddedHandler OnScoreAdded;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        // M�todo que se llamar� cuando el enemigo reciba un impacto
        public void Hit()
        {
            hitPoints--;
            if (hitPoints == 0)
            {
                Die();
            }
        }

        private void Die()
        {
            
            StartCoroutine(changingLight());
            
            
            

        }
        private IEnumerator changingLight()
        {
            animator.SetTrigger("Die");
            temporalLight.GetComponent<LightController>().onLight();
            yield return new WaitForSeconds(3f);
            temporalLight.GetComponent<LightController>().offLight();
            Destroy(this.gameObject);
        }
    }

}