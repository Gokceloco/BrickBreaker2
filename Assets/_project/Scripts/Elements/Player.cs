using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        var xPos = (Input.mousePosition / Screen.width * 4f).x - 2;

        xPos = Mathf.Clamp(xPos, -2, 2);

        transform.position = new Vector3(xPos, -4, 0);
    }
}
