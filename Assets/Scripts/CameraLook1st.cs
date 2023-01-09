using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CameraLook1st : MonoBehaviour
{
    [SerializeField]
    private float lookSpeed = 1;

    private CinemachineVirtualCamera cinemachine;
    private Player playerInput;
    private void Awake()
    {
        playerInput = new Player();
        cinemachine = GetComponent<CinemachineVirtualCamera>();
    }

    private void OnEnable()
    {
        playerInput.Enable();
    }

    private void OnDisable()
    {
        playerInput.Disable();
    }

    void Update()
    {
        CinemachinePOV pov = cinemachine.GetCinemachineComponent<CinemachinePOV>();
        Vector2 delta = playerInput.PlayerMain.Look.ReadValue<Vector2>();
        pov.m_HorizontalAxis.Value += delta.x * -1 * 200 * lookSpeed * Time.deltaTime;
        pov.m_VerticalAxis.Value += delta.y * -1 * lookSpeed * Time.deltaTime;
    }
}

