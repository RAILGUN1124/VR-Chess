using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CollisionHandlerBlack : MonoBehaviour
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
        if (collision.gameObject.CompareTag("BP1") || collision.gameObject.CompareTag("BP2") ||collision.gameObject.CompareTag("BP3") ||collision.gameObject.CompareTag("BP4") ||collision.gameObject.CompareTag("BP5")||collision.gameObject.CompareTag("BP6")
        ||collision.gameObject.CompareTag("BP7")||collision.gameObject.CompareTag("BP8")||collision.gameObject.CompareTag("BQ")||collision.gameObject.CompareTag("BK")||collision.gameObject.CompareTag("BB1")||collision.gameObject.CompareTag("BB2")||collision.gameObject.CompareTag("BR1")||collision.gameObject.CompareTag("BR2")||collision.gameObject.CompareTag("BKN1")||collision.gameObject.CompareTag("BKN2"))
        {
            // Ignore collision with the collided object while being grabbed
            if (grabInteractable.isSelected)
            {
                Physics.IgnoreCollision(collision.collider, grabInteractable.GetComponent<Collider>(), true);
            }
        }
    }
}