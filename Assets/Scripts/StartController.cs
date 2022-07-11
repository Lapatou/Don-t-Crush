using UnityEngine;
using UnityEngine.UI;

public class StartController : MonoBehaviour
{
    [SerializeField] Text startText;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            startText.enabled = false;
            Destroy(this);
        }
    }
}
