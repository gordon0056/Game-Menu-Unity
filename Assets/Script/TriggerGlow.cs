using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGlow : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystemContinue;
    [SerializeField] private ParticleSystem _particleSystemGiveUp;
    [SerializeField] private float _waitTimeContinue = 3f;
    [SerializeField] private float _waitTimeGiveUp = 6f;
    private float _idleTimer = 0f;
    private bool _particlesActive = false;

    private void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            // ���� ��������� �������������� � �������, ���������� ������ � ������������ �������� ������
            _idleTimer = 0f;
            //DeactivateParticles();
        }
        else
        {
            // ���� ��� ��������������, ����������� ������
            _idleTimer += Time.fixedDeltaTime;
            if (_idleTimer >= _waitTimeContinue && !_particlesActive)
            {
                // ���� ����� ����������� �������� 3 ������ � �������� ������ �� �������, ���������� ��
                ActivateParticles(_particleSystemContinue);
            }
            if (_idleTimer >= _waitTimeGiveUp && !_particlesActive)
            {
                // ���� ����� ����������� �������� 6 ������ � �������� ������ �� �������, ���������� ��
                DeactivateParticles(_particleSystemContinue);
                ActivateParticles(_particleSystemGiveUp);
            }
        }
    }

    private void ActivateParticles(ParticleSystem particle)
    {
        _particlesActive = true;
        particle.gameObject.SetActive(_particlesActive);
        particle.Play();  
    }

    private void DeactivateParticles(ParticleSystem particle)
    {
        particle.Stop();
        _particlesActive = false;
        particle.gameObject.SetActive(_particlesActive);
    }
}
