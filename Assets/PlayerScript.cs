using UnityEngine;
using UnityEngine.UI;

namespace PlayerMain
{
    public class PlayerScript : MonoBehaviour
    {
        [SerializeField] public float speed = 0.1f;
        [SerializeField] public int jumpPower = 0;
        [SerializeField] public float jumpm = 0;
        //[SerializeField] private int gravityScale = 1;


        //èâä˙ê›íË
        private bool groundcheck = false;
        private bool leftpush = false;
        private bool rightpush = false;

        private Rigidbody rb;
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }



        public void RightPushDown()
        {
            rightpush = true;
        }
        public void RightPushUp()
        {
            rightpush = false;
        }

        public void OnClickRight()
        {
            Vector3 position = transform.position;
            position.x += speed;
            transform.position = position;
        }


        public void LeftPushDown()
        {
            leftpush = true;
        }
        public void LeftPushUp()
        {
            leftpush = false;
        }
        public void OnClickLeft()
        {
            Vector3 position = transform.position;
            position.x -= speed;
            transform.position = position;

        }

        void Update()
        {
            if (rightpush)
            {
                OnClickRight();
            }
            if (leftpush)
            {
                OnClickLeft();
            }
        }


        private void OnCollisionStay()
        {

            groundcheck = true;
        }
        private void OnCollisionExit()
        {

            groundcheck = false;
        }
        public void OnrightJump()
        {

            if (groundcheck == true)
            {
                Vector3 force = new Vector3(-jumpm, jumpPower, 0.0f);  // óÕÇê›íË
                rb.AddForce(force, ForceMode.Impulse);

            }

        }
        public void OnLeftJump()
        {

            if (groundcheck == true)
            {
                Vector3 force = new Vector3(jumpm, jumpPower, 0.0f);  // óÕÇê›íË
                rb.AddForce(force, ForceMode.Impulse);

            }

        }
    }

}


