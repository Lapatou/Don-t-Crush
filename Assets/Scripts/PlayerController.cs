using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    private Vector3 pointA;
    private Vector3 pointB;
    private bool touchStart = false;


    void Start()
    {
    }

    void Update()
    {
        CheckInputs();
        RotateAndMove();
    }

    private void CheckInputs()
    {
        if (Input.GetMouseButtonDown(0))
        {
            touchStart = true;
            pointA = new Vector3(Input.mousePosition.x, 0, Input.mousePosition.y);
        }

        if (Input.GetMouseButton(0))
        {
            pointB = new Vector3(Input.mousePosition.x, 0, Input.mousePosition.y);
        }
        else
        {
            touchStart = false;
        }
    }

    private void RotateAndMove()
    {
        if (touchStart)
        {
            Vector3 offset = pointB - pointA;
            Vector3 direction = Vector3.ClampMagnitude(offset, 1.0f);
            transform.rotation = Quaternion.LookRotation(direction);
            transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
        }

    }
}
