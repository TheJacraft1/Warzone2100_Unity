
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CameraMovement : MonoBehaviour
{
    // Speed at which the camera moves
    public float movementSpeed = 10.0f;

    public float edgeSensitivity = 10.0f;

    public float maxMovementSpeed = 50.0f;

    // Update is called once per frame
    void Update()
    {
        // Move the camera with WASD or arrow keys
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0.0f, vertical) * movementSpeed * Time.deltaTime);

        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }

        Vector3 mousePos = Input.mousePosition;

        // Check if the mouse is at the edge of the screen
        if (mousePos.x < edgeSensitivity)
        {
            // Calculate the movement speed based on the distance to the edge
            float speed = Mathf.Lerp(maxMovementSpeed, 0.0f, mousePos.x / edgeSensitivity);

            // Move the camera to the left
            transform.position += -transform.right * speed * Time.deltaTime;
        }
        else if (mousePos.x > Screen.width - edgeSensitivity)
        {
            // Calculate the movement speed based on the distance to the edge
            float speed = Mathf.Lerp(maxMovementSpeed, 0.0f, (Screen.width - mousePos.x) / edgeSensitivity);

            // Move the camera to the right
            transform.position += transform.right * speed * Time.deltaTime;
        }

        if (mousePos.y < edgeSensitivity)
        {
            // Calculate the movement speed based on the distance to the edge
            float speed = Mathf.Lerp(maxMovementSpeed, 0.0f, mousePos.y / edgeSensitivity);

            // Move the camera down
            transform.position += -transform.forward * speed * Time.deltaTime;
        }
        else if (mousePos.y > Screen.height - edgeSensitivity)
        {
            // Calculate the movement speed based on the distance to the edge
            float speed = Mathf.Lerp(maxMovementSpeed, 0.0f, (Screen.height - mousePos.y) / edgeSensitivity);

            // Move the camera up
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}