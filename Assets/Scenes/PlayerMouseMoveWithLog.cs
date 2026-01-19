using UnityEngine;

public class PlayerMouseMoveWithLog : MonoBehaviour
{
    public float speed = 30f;
    Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Debug.Log("Mouse position: " + mousePos);

            Vector3 worldPos = cam.ScreenToWorldPoint(mousePos);
            worldPos.z = transform.position.z;

            transform.position = Vector3.MoveTowards(
                transform.position,
                worldPos,
                speed * Time.deltaTime
            );
        }
    }
}