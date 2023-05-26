using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class takecrontrol : MonoBehaviour
{
    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    private void Update()
    {
        if (grabInteractable.isSelected)
        {
            // Get the movement input from the VR controller
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            // Calculate the movement vector based on the input
            Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

            // Apply the movement to the object's rigidbody
            GetComponent<Rigidbody>().velocity = movement;
        }
    }
}
