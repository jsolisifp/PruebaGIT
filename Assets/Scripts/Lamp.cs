using UnityEngine;

public class Lamp: MonoBehaviour
{

    public bool IsOn;
    Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(IsOn)
        {
            animator.SetBool("IsOn", true);
        }
        else
        {
            animator.SetBool("IsOn", false);
        }
    }
}
