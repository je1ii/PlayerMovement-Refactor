using UnityEngine;

public class BloodFX : MonoBehaviour
{
    [Header("Effects")]
    [SerializeField] private ParticleSystem partSys;

    public void PlayFX()
    {
        partSys.Play();
    }
}
