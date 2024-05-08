using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    public void MoveSetup(float MoveSpeed)
    {
        if(MoveSpeed > 0)
        {
        var valueX = Input.GetAxis("Horizontal");
        var valueY = Input.GetAxis("Vertical");

        if (valueX > 0)
            transform.position += new Vector3(valueX, 0, 0) * MoveSpeed * Time.deltaTime;
        if (valueX < 0)
            transform.position += new Vector3(valueX, 0, 0) * MoveSpeed * Time.deltaTime;
        if (valueY > 0)
            transform.position += new Vector3(0, valueY, 0) * MoveSpeed * Time.deltaTime;
        if (valueY < 0)
            transform.position += new Vector3(0, valueY, 0) * MoveSpeed * Time.deltaTime;
        }
    }
}
