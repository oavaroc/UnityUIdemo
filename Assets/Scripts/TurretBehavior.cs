using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretBehavior : MonoBehaviour
{
    [SerializeField]
    private float _force = 500f;
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private Transform _instantiationPoint;

    public void SpawnCannonBall()
    {
        if(Instantiate(_bullet, _instantiationPoint.position, _instantiationPoint.rotation).TryGetComponent(out Rigidbody rb))
        {
            rb.AddRelativeForce(Vector3.left * _force,ForceMode.Impulse);

        }
        else
        {
            Debug.Log("Cannon ball has no rigidbody");
        }
    }
    public void RotateCannon(int degrees)
    {
        transform.Rotate(Vector3.up * degrees);
    }
}
