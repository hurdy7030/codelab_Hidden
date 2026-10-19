using UnityEngine;

public class Closet_behave : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        animator.speed = 0;
    }

    public void Open()
    {
        animator.speed = 1;
        GetComponent<Collider2D>().enabled = false;
    }
}