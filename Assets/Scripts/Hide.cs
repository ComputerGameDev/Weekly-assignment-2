using UnityEngine;
using UnityEngine.InputSystem;

public class ObjectHider : MonoBehaviour
{
    private Renderer objectRenderer;
    private bool isObjectHidden = false;
    [SerializeField]
    InputAction moveDown = new InputAction(type: InputActionType.Button);

    void OnEnable()  {
        moveDown.Enable();
    }

    void OnDisable()  {
        moveDown.Disable();
    }

    void Start()
    {
        objectRenderer = GetComponent<Renderer>();
        if (objectRenderer == null)
        {
            Debug.LogError("Renderer component not found on the object.");
            enabled = false;
        }
    }

    void Update()
    {
        if (moveDown.WasPressedThisFrame()) {
            ToggleObjectVisibility();
        }
    }
    
    void ToggleObjectVisibility()
    {
        isObjectHidden = !isObjectHidden;
        if (objectRenderer != null)
        {
            objectRenderer.enabled = !isObjectHidden;
        }
        else
        {
            Debug.LogError("Renderer component not found on the object.");
        }
    }
}
