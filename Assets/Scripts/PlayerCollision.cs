
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public ParticleSystem hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ContactPoint2D contact = collision.GetContact(0);

        Instantiate(
            hitEffect,
            contact.point,
            Quaternion.identity
        );
    }
}
