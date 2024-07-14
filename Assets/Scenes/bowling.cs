using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class bowling : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Rigidbody rb;

    [SerializeField]
    private int forcePower;

    [SerializeField]
    private float increment;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            Shootbowl();

        if (Input.GetKey(KeyCode.A))
        Moveleft();

        if (Input.GetKey(KeyCode.D))
        Moveright();
    }

    public void Shootbowl()
    {
        rb.AddForce(Vector3.forward * forcePower * -1, ForceMode.Impulse);
    }

    public void Moveleft()
    {
        transform.position += new Vector3(+increment, 0f, 0f);
    }

    public void Moveright()
    {
        transform.position += new Vector3(-increment, 0f, 0f);
    }
}
