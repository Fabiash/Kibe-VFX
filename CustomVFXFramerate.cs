using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomVFXFramerate : MonoBehaviour
{
    public int fps;
    ParticleSystem particle;
    private float timeElapsed = 0f;
    private float displayTime = 0f;

    // Start is called before the first frame update
    void OnEnable()
    {
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        timeElapsed += Time.deltaTime;

        if ((timeElapsed - displayTime) > 1f / fps)
        {
            displayTime = timeElapsed;
            particle.Simulate((1f/fps), true, false, false);
            particle.Pause();
        }

    }
}
