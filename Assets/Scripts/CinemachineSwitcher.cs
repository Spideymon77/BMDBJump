using UnityEngine;
using Cinemachine;

public class CinemachineSwitcher : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera mainCam;
    [SerializeField] private CinemachineVirtualCamera downCam;

    //private Animator animator;

    // Start is called before the first frame update
    void Awake()
    {
        //animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            downCam.Priority = 1;
            mainCam.Priority = 0;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            downCam.Priority = 0;
            mainCam.Priority = 1;
        }
    }
}
