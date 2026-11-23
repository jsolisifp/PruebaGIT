using UnityEngine;

public class CharacterMovementTransform : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Colocar al personaje en una posición, rotación y escala
        // transform.position = new Vector3(4.0f, 2.0f, -3.0f);
        // transform.rotation = Quaternion.Euler(45, 90, -45);
        // transform.localScale = new Vector3(1, 2, 5);

        // Desplazamiento hacia adelante de personaje con diferentes tecnicas, las 4 opciones sirven para lo mismo

        // transform.position = transform.position + new Vector3(0, 0, 1) * Time.deltaTime;

        // transform.position = transform.position + Vector3.forward * Time.deltaTime;
        // transform.position += Vector3.forward * Time.deltaTime;

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime, Space.Self);
        }

        // Ir hacia atrás
        if(Input.GetKey(KeyCode.A))
        {
            // transform.localRotation = transform.localRotation * Quaternion.Euler(0, -45 * Time.deltaTime, 0);
            transform.Rotate(0, -45 * Time.deltaTime, 0, Space.Self);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            // transform.localRotation = transform.localRotation * Quaternion.Euler(0, 45 * Time.deltaTime, 0);
            transform.Rotate(0, 45 * Time.deltaTime, 0, Space.Self);

        }

        if(transform.position.x < -5)
        {
            transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > 5)
        {
            transform.position = new Vector3(-5, transform.position.y, transform.position.z);
        }

    }
}
