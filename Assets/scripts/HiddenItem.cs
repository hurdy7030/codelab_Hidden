using UnityEngine;
using UnityEngine.UI;

public class HiddenItem : MonoBehaviour
{
    public Image uiIcon;
    public GameManager game;
    

    bool found;

    public void Collect()
    {
        if (found) return;
        found = true;
        
        uiIcon.color *=new Color(0.3f,0.3f,0.3f,1f);
        game.AddScore();
        Destroy(gameObject);
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
