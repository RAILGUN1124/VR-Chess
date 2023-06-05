using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CollisionHandler : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        // Get reference to XRGrabInteractable component on this object
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is tagged as pieces
        if (collision.gameObject.CompareTag("WP1") || collision.gameObject.CompareTag("WP2") ||collision.gameObject.CompareTag("WP3") ||collision.gameObject.CompareTag("WP4") ||collision.gameObject.CompareTag("WP5")||collision.gameObject.CompareTag("WP6")
        ||collision.gameObject.CompareTag("WP7")||collision.gameObject.CompareTag("WP8")||collision.gameObject.CompareTag("WQ")||collision.gameObject.CompareTag("WK")||collision.gameObject.CompareTag("WB1")||collision.gameObject.CompareTag("WB2")||collision.gameObject.CompareTag("WR1")||collision.gameObject.CompareTag("WR2")||collision.gameObject.CompareTag("WKN1")||collision.gameObject.CompareTag("WKN2"))
        {
            // Ignore collision with the collided object while being grabbed
            if (grabInteractable.isSelected)
            {
                Physics.IgnoreCollision(collision.collider, grabInteractable.GetComponent<Collider>(), true);
            }
        }
    }
}