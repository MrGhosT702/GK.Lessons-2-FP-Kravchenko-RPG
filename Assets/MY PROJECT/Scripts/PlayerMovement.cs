using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG
{


    public class PlayerMovement : MonoBehaviour
    {
        private Vector3 direction;
        [SerializeField] private float speed = 5f;


        private void Update()
        {

            direction.x = Input.GetAxis("Horizontal");
            direction.z = Input.GetAxis("Vertical");
        }

        private void FixedUpdate()
        {
            transform.position += direction * speed * Time.fixedDeltaTime;
        }
    }
}

