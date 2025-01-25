using UnityEngine;

public class WallCollision : MonoBehaviour
{
    [Header("Collision")]
    [SerializeField] private LayerMask layerMask;

    [SerializeField] private BloodFX fx;
    [SerializeField] private PlayerAudio playerAudio;

    public GameObject effectHolder;
    public GameObject audioHolder;

    private void Awake()
    {
        fx = effectHolder.GetComponent<BloodFX>();
        playerAudio = audioHolder.GetComponent<PlayerAudio>();
    }

    void OnCollisionEnter(Collision hit)
    {
        if ((layerMask.value & (1 << hit.gameObject.layer)) > 0)
        {
            //Debug.Log("player hit");
            fx.PlayFX();
            playerAudio.PlayAudio();
        }
    }
}
