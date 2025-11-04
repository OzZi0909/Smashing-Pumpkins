using UnityEngine;

public class PlayOnClick : MonoBehaviour
{
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 = Left Mouse Button
        {
            animator.SetTrigger("Swing");
        }
    }
}