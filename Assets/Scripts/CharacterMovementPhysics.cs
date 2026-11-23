using UnityEngine;

public class CharacterMovementPhysics : MonoBehaviour
{

    [Header("Keys")]
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Forces")]
    public float forwardForce = 500.0f;
    public float backwardsForce = 500.0f;
    public float rotateTorque = 50.0f;

    public Rigidbody rigid;

    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rigid = gameObject.GetComponent<Rigidbody>();

        rigid.inertiaTensor = rigid.inertiaTensor;

    }

    // Update is called once per frame
    void Update()
    {
        // animator.SetFloat("Speed", 0.0f);




        if (Input.GetKey(upKey))
        {
            Vector3 forceGlobal = transform.forward * forwardForce;
            rigid.AddForce(forceGlobal);
            // animator.SetFloat("Speed", 1.0f);
        }
        else if (Input.GetKey(downKey))
        {
            Vector3 forceGlobal = -transform.forward * backwardsForce;
            rigid.AddForce(forceGlobal);
            // animator.SetFloat("Speed", 1.0f);
        }

        if (Input.GetKey(leftKey))
        {
            rigid.AddRelativeTorque(0, -rotateTorque, 0);
            // animator.SetFloat("Speed", 1.0f);
        }
        else if (Input.GetKey(rightKey))
        {
            rigid.AddRelativeTorque(0, rotateTorque, 0);
            //animator.SetFloat("Speed", 1.0f);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (animator != null) { animator.SetTrigger("Attack"); }
        }


        if (Input.GetKeyDown(jumpKey))
        {
            rigid.AddForce(0, 1000, 0, ForceMode.Impulse);
        }

        float s;
        s = rigid.linearVelocity.magnitude;

        if (animator != null) { animator.SetFloat("Speed", s); }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody == null)
        {
            return;
        }

        Vector3 forceGlobal = transform.forward * 5 + transform.up * 3;
        collision.rigidbody.AddForce(forceGlobal, ForceMode.Impulse);


    }

    /*
    [Header("Keys")]
    public KeyCode upKey = KeyCode.W;
    public KeyCode downKey = KeyCode.S;
    public KeyCode leftKey = KeyCode.A;
    public KeyCode rightKey = KeyCode.D;
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Forces")]
    public float forwardForce = 500.0f;
    public float backwardsForce = 500.0f;
    public float rotateTorque = 50.0f; 


    public Rigidbody rigid;

    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // rigid = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", 0.0f);

        if (Input.GetKey(upKey))
        {
            Vector3 forceGlobal = transform.forward * forwardForce;
            rigid.AddForce(forceGlobal);
            //animator.SetFloat("Speed", 1.0f);
        }
        else if(Input.GetKey(downKey))
        {
            Vector3 forceGlobal = - transform.forward * backwardsForce;
            rigid.AddForce(forceGlobal);
            //animator.SetFloat("Speed", 1.0f);
        }
        
        if(Input.GetKey(leftKey))
        {
            rigid.AddRelativeTorque(0, -rotateTorque, 0);
            //animator.SetFloat("Speed", 1.0f);
        }
        else if (Input.GetKey(rightKey))
        {
            rigid.AddRelativeTorque(0, rotateTorque, 0);
        }

        if(Input.GetKeyDown(jumpKey))
        {
            rigid.AddForce(0, 500, 0,ForceMode.Impulse);
            //animator.SetFloat("Speed", 1.0f);
        }

        float speed;
        speed = rigid.linearVelocity.magnitude;

        animator.SetFloat("Speed", speed);

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.rigidbody == null)
        {
            return;
        }

        //Vector3 forceGlobal = transform.forward * 5 + transform.up * 3;
        //collision.rigidbody.AddForce(forceGlobal, ForceMode.Impulse);
    } */
}
