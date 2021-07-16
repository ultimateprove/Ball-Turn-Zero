using UnityEngine;



public class BallRotate : MonoBehaviour
{

    bool _direction = false;
    [SerializeField] GameObject circleCenter;
    private void FixedUpdate() 
    {
        if (_direction == false)
        {
            circleCenter.transform.Rotate(0,0,150 * Time.deltaTime);
        }
        else
        {
            circleCenter.transform.Rotate(0,0,-150 * Time.deltaTime);
        }
    }

    public void ChangeDirection()
    {
        _direction = !_direction;
    }
    
}
