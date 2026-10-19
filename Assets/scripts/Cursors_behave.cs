using UnityEngine;
using UnityEngine.InputSystem;

public class Cursors_behave : MonoBehaviour
{
    float minX, maxX, minY, maxY;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float Height = Camera.main.orthographicSize;
        float Width = Height * Camera.main.aspect;
        
        minX = Camera.main.transform.position.x - Width;
        maxX = Camera.main.transform.position.x + Width;
        minY = Camera.main.transform.position.y - Height;
        maxY = Camera.main.transform.position.y + Height;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        if (mousePosition.x > minX && mousePosition.x < maxX && mousePosition.y > minY && mousePosition.y < maxY)
        {
            transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
        }
    }
}
