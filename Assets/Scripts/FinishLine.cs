using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
    [SerializeField] Text timeText;

    private GameObject camera;
    private GameObject player;

    private void Start()
    {
        camera = FindObjectOfType<CameraMovement>().gameObject;
        player = FindObjectOfType<PlayerController>().gameObject;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<PlayerController>().enabled = false;

            camera.GetComponent<CameraMovement>().enabled = false;
            camera.GetComponent<FinishCameraSwitch>().enabled = true;

            timeText.enabled = false;
        }
    }
}
