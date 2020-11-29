using Packages.Rider.Editor.Util;
using UnityEngine;

public class Main : MonoBehaviour
{
    public Rigidbody СubeRB;
    public Vector3 vector;
    public float acceleration;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            СubeRB.AddForce(vector.normalized * acceleration, ForceMode.Impulse);
        }
    }
}
