using UnityEngine;
using UnityEngine.UI;

public class StartController : MonoBehaviour
{
    [SerializeField] Text startText;
    [SerializeField] Text rankText;
    [SerializeField] OpponentController[] opponents;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            startText.enabled = false;
            rankText.enabled = true;
            Destroy(this);
        }
    }
}
