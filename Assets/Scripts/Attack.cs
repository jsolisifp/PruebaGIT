using UnityEngine;

public class Attack : MonoBehaviour
{
    [Tooltip("Dejar a nulo para el personaje principal.")]
    public Sensor detectArea;

    public Transform attackArea;

    public Animator animator;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (detectArea != null)
        {
            if(detectArea.presence)
            {
                if (animator != null) { animator.SetTrigger("Attack"); }
            }
        }


        if(animator != null)
        {
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Attack"))
            {
                attackArea.gameObject.SetActive(true);
            }
            else
            {
                attackArea.gameObject.SetActive(false);
            }

        }
    }
}
