using UnityEngine;

    
public class ShowLogMouse : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Debug.Log("Mouse position: " + mousePos);
        }
    }
}