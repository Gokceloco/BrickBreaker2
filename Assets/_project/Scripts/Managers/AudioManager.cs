using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource impactAS;
    public AudioSource brickHitAS;
    public AudioSource failAS;

    public void PlayImpactAS()
    {
        impactAS.Play();
    }
    public void PlayBrickHitAS()
    {
        brickHitAS.Play();
    }
    public void PlayFailAS()
    {
        failAS.Play();
    }
}
