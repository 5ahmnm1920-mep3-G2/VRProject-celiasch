using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public int playerSpeed;

    void Update()
    {
        if (Input.GetButton("Fire1"))
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime; 
    }
}
