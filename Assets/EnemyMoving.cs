using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoving : MonoBehaviour
{
    private Rigidbody2D _rb;
   public void MoveTo(Vector3 _targetPoint)
    {
        _rb.MovePosition(_targetPoint);
    }
}
