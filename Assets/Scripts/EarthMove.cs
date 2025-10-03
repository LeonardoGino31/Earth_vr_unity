using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class EarthMove : MonoBehaviour
{

    Vector3 vector = new Vector3(0, 5f, 0);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vector * Time.deltaTime);
    }
}
