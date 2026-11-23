using UnityEngine;

public class SwitchInterruptor : MonoBehaviour
{

    public bool IsOn;

    public Animator animator;
    public Sensor sensor;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ponemos la variable isOn según lo que diga el sensor
        if(sensor.presenceEnter)
        {
            IsOn = true;
        }
        else
        {
            IsOn = false;
        }

        //Copiamos la variable en el parametro del animator
        if(IsOn == true)
        {
            animator.SetBool("IsOn", true);
        }
        else
        {
            animator.SetBool("IsOn", false);
        }
        
    }
     private void Awake()
    {
        
    }
}
