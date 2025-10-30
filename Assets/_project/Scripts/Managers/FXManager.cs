using UnityEngine;

public class FXManager : MonoBehaviour
{
    public ParticleSystem impactPS;

    public void PlayImpactPS(Vector3 pos)
    {
        var newPS = Instantiate(impactPS);
        newPS.transform.position = pos;
        newPS.Play();
    }
}
