using UnityEngine;

namespace TKH3DCoffee
{
    public class PlayerController : MonoBehaviour
    {
        public LayerMask movementMask;      // The ground
        public LayerMask interactionMask;
        PlayerMotor motor;

        Camera cam;
        public void Start()
        {
            motor = GetComponent<PlayerMotor>();
            cam = Camera.main;
        }

        public void Update()
        {

            if (Input.GetMouseButtonDown(0))
            {
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit, movementMask))
                {
                    motor.MoveToPoint(hit.point);
                }
            }
        }
    }
}
