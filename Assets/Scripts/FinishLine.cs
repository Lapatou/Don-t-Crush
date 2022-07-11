using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{

    private new GameObject camera;
    private GameObject player;

    public LevelLoader levelLoader=null;

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

            if(levelLoader != null)
            {
                levelLoader.LoadNextLevel();
            }

        }
    }
}
