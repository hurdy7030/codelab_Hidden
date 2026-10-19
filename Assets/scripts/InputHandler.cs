using UnityEngine;
using UnityEngine.InputSystem;
public class InputHandler : MonoBehaviour
{
    private Camera _mainCamera;

    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;
        
        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider)return;
        
        Debug.Log(rayHit.collider.gameObject.name);
        
        var wrongItem = rayHit.collider.GetComponent<WrongItem>();

        if (wrongItem != null)
        {
            wrongItem.Click();
            return;
        }
        
        var item = rayHit.collider.GetComponent<HiddenItem>();

        if (item != null)
        {
            item.Collect();
            return;
        }
        
        var closet = rayHit.collider.GetComponent<Closet_behave>();

        if (closet != null)
            closet.Open();
        
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
