using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;

    CameraChange cameraChange;

    void Awake()
    {
        cameraChange = GetComponent<CameraChange>();
    }

    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y + 1.5f, transform.position.z);

        if (cameraChange.moveCameraDown == true)
        {
            transform.position = new Vector3(player.position.x, player.position.y - 2f, transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Camera Down"))
        {
            cameraChange.moveCameraDown = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Camera Down"))
        {
            cameraChange.moveCameraDown = false;
        }
    }
}
