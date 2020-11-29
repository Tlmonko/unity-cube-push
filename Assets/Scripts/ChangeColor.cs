using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        var wall = collider.gameObject.GetComponent<Renderer>();
        wall.material.color = Random.ColorHSV();
    }
}
