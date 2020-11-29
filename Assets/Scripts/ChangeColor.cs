using UnityEngine;

public class ColorfulWall : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        var wall = collider.gameObject.GetComponent<Renderer>();
        wall.material.color = Random.ColorHSV();
    }
}
