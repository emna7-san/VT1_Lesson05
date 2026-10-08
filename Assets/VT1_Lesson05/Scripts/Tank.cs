using UnityEngine;
using UnityEngine.InputSystem;

//戦車のコントロールクラス


public class Tank : MonoBehaviour
{
   
    [SerializeField] private Transform topJoint;

    [SerializeField] private Transform connonJoint;

    private Vector3 topAngles = Vector3.zero;

    private Vector3 cannonAngles = Vector3.zero;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed == true)
        {
            transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        }

        if (Keyboard.current.sKey.isPressed == true)
        {
            transform.Translate(Vector3.forward * -5 * Time.deltaTime);
        }
        if (Keyboard.current.aKey.isPressed == true)
        {
            transform.Rotate(Vector3.up * -90 * Time.deltaTime);
        }
        if (Keyboard.current.dKey.isPressed == true)
        {
            transform.Rotate(Vector3.up * 90 * Time.deltaTime);
        }

        //マウスの移動量を取得する
        Vector2 mouseDelta = Mouse.current.delta.ReadValue();
        topAngles.y += mouseDelta.x  * 0.1f;
        cannonAngles.x -= mouseDelta.y * 0.1f;

        topJoint.localEulerAngles = topAngles;
        //CannonJoint.localEulerAngles = cannonAngles;

   }
}
