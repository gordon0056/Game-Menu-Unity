using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGlow : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystemContinue;
    [SerializeField] private ParticleSystem _particleSystemGiveUp;
    [SerializeField] private float _waitTimeContinue = 3f;
    [SerializeField] private float _waitTimeGiveUp = 3f;
    private float _idleTimer = 0f;
    private bool _particlesActive = false;

    private void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            _idleTimer = 0f;
            DeactivateParticles(_particleSystemContinue);
            DeactivateParticles(_particleSystemGiveUp);
            
        }
        else
        {
            _idleTimer += Time.deltaTime;
            if (_idleTimer >= _waitTimeContinue && !_particlesActive)
            {
                ActivateParticles(_particleSystemContinue);
                ActivateParticles(_particleSystemGiveUp);
            }
            /*if (_idleTimer >= _waitTimeGiveUp && !_particlesActive)
            {
                DeactivateParticles(_particleSystemContinue);
              
            }
            */
        }
    }

    private void ActivateParticles(ParticleSystem particle)
    {
        _particlesActive = true;
        //particle.gameObject.SetActive(_particlesActive);
        particle.Play();  
    }

    private void DeactivateParticles(ParticleSystem particle)
    {
        particle.Stop();
        _particlesActive = false;
        //particle.gameObject.SetActive(_particlesActive);
    }
}
