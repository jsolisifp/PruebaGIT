using UnityEngine;

public class Door : MonoBehaviour
{
    public bool isLocked;
    public bool isOpen;
    public Animator animator;
    public Sensor sensor;
    public Transform blocker;
    public Animator eye1Animator;
    public Animator eye2Animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isLocked)
        {
            isOpen = false;
            animator.SetBool("isOpen", false);
            blocker.gameObject.SetActive(true);

        }
        else if (sensor.presence)
        {
            isOpen = true;
            animator.SetBool("IsOpen", true);
            blocker.gameObject.SetActive(false);
        }
        else
        {
            isOpen = false;
            animator.SetBool("IsOpen", false);
            blocker.gameObject.SetActive(true);
        }

        /// Manage Locked

        if(isLocked)
        {
            eye1Animator.SetBool("IsLocked", true);
            eye2Animator.SetBool("IsLocked", true);
        }
        else
        {
            eye1Animator.SetBool("IsLocked", false);
            eye2Animator.SetBool("IsLocked", false);
        }
    }
}
