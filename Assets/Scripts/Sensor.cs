using UnityEngine;

public class Sensor : MonoBehaviour
{
    public bool presenceEnter;
    public bool presence;

    public float forgetTime = 0.2f;

    float presenceTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        presenceTimer = presenceTimer - Time.deltaTime;

        if(presenceTimer <= 0)
        {
            presence = false;
        }
    }

    private void LateUpdate()
    {
        presenceEnter = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (presence == false)
        {
            presenceEnter = true;
        }

        presence = true;

        presenceTimer = forgetTime;
    }

 
    void OnTriggerStay(Collider other)
    {
        if (presence == false)
        {
            presenceEnter = true;
        }

        presence = true;

        presenceTimer = forgetTime;
    }
}
