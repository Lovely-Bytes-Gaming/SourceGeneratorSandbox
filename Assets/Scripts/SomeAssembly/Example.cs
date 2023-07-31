using UnityEngine;
using static GetComponentAttribute.TargetType;

public partial class Example : MonoBehaviour
{
    [GetComponent]
    private new Renderer renderer;

    [GetComponent(Child)]
    private new Rigidbody rigidbody;

    [GetComponent(Parent)]
    private new Camera camera;

    [GetSingleton]
    private SomeSingleton singleton;

    private void Awake() => InitializeFields();

    private void Start()
    {
        Debug.Log("My Renderer is: " + renderer ?? "NULL");
        Debug.Log("My RigidBody is: " + rigidbody ?? "NULL");
        Debug.Log("My Camera is: " + camera ?? "NULL");
        singleton.Greet();
    }


}
