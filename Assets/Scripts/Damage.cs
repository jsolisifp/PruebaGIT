using UnityEngine;

public class Damage : MonoBehaviour
{
    public float health = 100;
    public float damagePerHit = 30;

    public Animator animator;
    public Sensor sensor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sensor.presenceEnter)
        {
            health = health - damagePerHit;

            if(health <= 0)
            {
                animator.SetTrigger("Death");
            }
            else
            {
                animator.SetTrigger("Damage");
            }

            animator.SetTrigger("Damage");
        }
        
    }
}
