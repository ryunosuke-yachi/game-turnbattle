using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationEvent : MonoBehaviour
{
    [SerializeField] private ParticleSystem particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void particlePlay()
    {
        particle.Play();
        Debug.Log("particlePlay");
    }

    void particleStop()
    {
        particle.Stop();
        Debug.Log("particleStop");
    }
}
