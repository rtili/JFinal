using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private void OnCollisionStay2D(Collision2D collision)
    {
        TryGetComponent(out IOnCollider collider);
        collider.OnCollider = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        TryGetComponent(out IOnCollider collider);
        collider.OnCollider = false;
    }
}
