//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""ChapterOne"",
            ""id"": ""32d18a1b-b41f-4189-8e76-2d2e3b751aae"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""16c1df72-4de4-4ffc-95e2-74a6074e372b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9ca50d20-17c8-4071-98b2-ffa12ff92c2b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""66d12ce0-3003-4e98-be0e-4fa6ebfa3967"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""b92cd99b-3721-4c18-bdc3-59dc8790d1cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""aa2e525e-4812-41f6-871b-2fb0e7ebe390"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""dfba11d7-1b07-4fff-9279-abd316a18fef"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""32ee7dc2-826d-40ba-8e0e-4a343cc47639"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis AD"",
                    ""id"": ""181a638a-6af6-400f-9338-3ecbd4cbe054"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""08a161f4-b43f-42fe-93b4-05f947870689"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6b8e9880-19b6-4190-909c-d93d982dad07"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""2ff30c2b-5981-4880-880b-8ff0f6e85e8f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fde67b99-be99-4411-a723-cb24984ac374"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0c251df-3f47-4a50-a187-8c05a276626e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""195b26e3-f341-40fe-bbb9-6c9474a4cf2b"",
                    ""path"": ""<Touchscreen>/Press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c4a70d34-4ebf-4d05-9fac-e7d756bc655a"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""ChapterTwo"",
            ""id"": ""3d5b0aea-8d38-428d-b362-0436ec362c14"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f89afef2-4d41-426b-b127-573227a51400"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Blast"",
                    ""type"": ""Button"",
                    ""id"": ""d4412e50-9058-471b-b1ad-c5ec7449df60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""932b777b-5135-4339-bd73-3a63b094431c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""760cfcb9-fdc9-429e-ad64-feebd5c72d08"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""56e93fa5-88c9-4034-99d9-2978fe96b118"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""18c5f3fe-bbfd-4841-a962-04b409119ec5"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ffa4e57e-1f25-4250-b41f-1af0c4e23763"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis AD"",
                    ""id"": ""4f5f945b-5a64-422b-a6ba-3e6cde083d17"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5f4a26e0-3207-4519-8888-9dd6a16d545a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9b2e192f-13f8-43ff-87e4-8846f82f1f0e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""085bebc1-3973-45b9-b8ed-4e845de0b6af"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bb5b58c2-b919-43d4-bbbc-359df539da86"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9a6622e-1653-414e-bdd6-472379e8c513"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Blast"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ChapterOne
        m_ChapterOne = asset.FindActionMap("ChapterOne", throwIfNotFound: true);
        m_ChapterOne_Move = m_ChapterOne.FindAction("Move", throwIfNotFound: true);
        m_ChapterOne_Jump = m_ChapterOne.FindAction("Jump", throwIfNotFound: true);
        m_ChapterOne_Interact = m_ChapterOne.FindAction("Interact", throwIfNotFound: true);
        m_ChapterOne_Submit = m_ChapterOne.FindAction("Submit", throwIfNotFound: true);
        // ChapterTwo
        m_ChapterTwo = asset.FindActionMap("ChapterTwo", throwIfNotFound: true);
        m_ChapterTwo_Shoot = m_ChapterTwo.FindAction("Shoot", throwIfNotFound: true);
        m_ChapterTwo_Blast = m_ChapterTwo.FindAction("Blast", throwIfNotFound: true);
        m_ChapterTwo_Jump = m_ChapterTwo.FindAction("Jump", throwIfNotFound: true);
        m_ChapterTwo_Move = m_ChapterTwo.FindAction("Move", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // ChapterOne
    private readonly InputActionMap m_ChapterOne;
    private List<IChapterOneActions> m_ChapterOneActionsCallbackInterfaces = new List<IChapterOneActions>();
    private readonly InputAction m_ChapterOne_Move;
    private readonly InputAction m_ChapterOne_Jump;
    private readonly InputAction m_ChapterOne_Interact;
    private readonly InputAction m_ChapterOne_Submit;
    public struct ChapterOneActions
    {
        private @PlayerControls m_Wrapper;
        public ChapterOneActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_ChapterOne_Move;
        public InputAction @Jump => m_Wrapper.m_ChapterOne_Jump;
        public InputAction @Interact => m_Wrapper.m_ChapterOne_Interact;
        public InputAction @Submit => m_Wrapper.m_ChapterOne_Submit;
        public InputActionMap Get() { return m_Wrapper.m_ChapterOne; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChapterOneActions set) { return set.Get(); }
        public void AddCallbacks(IChapterOneActions instance)
        {
            if (instance == null || m_Wrapper.m_ChapterOneActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ChapterOneActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Submit.started += instance.OnSubmit;
            @Submit.performed += instance.OnSubmit;
            @Submit.canceled += instance.OnSubmit;
        }

        private void UnregisterCallbacks(IChapterOneActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Submit.started -= instance.OnSubmit;
            @Submit.performed -= instance.OnSubmit;
            @Submit.canceled -= instance.OnSubmit;
        }

        public void RemoveCallbacks(IChapterOneActions instance)
        {
            if (m_Wrapper.m_ChapterOneActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IChapterOneActions instance)
        {
            foreach (var item in m_Wrapper.m_ChapterOneActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ChapterOneActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ChapterOneActions @ChapterOne => new ChapterOneActions(this);

    // ChapterTwo
    private readonly InputActionMap m_ChapterTwo;
    private List<IChapterTwoActions> m_ChapterTwoActionsCallbackInterfaces = new List<IChapterTwoActions>();
    private readonly InputAction m_ChapterTwo_Shoot;
    private readonly InputAction m_ChapterTwo_Blast;
    private readonly InputAction m_ChapterTwo_Jump;
    private readonly InputAction m_ChapterTwo_Move;
    public struct ChapterTwoActions
    {
        private @PlayerControls m_Wrapper;
        public ChapterTwoActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_ChapterTwo_Shoot;
        public InputAction @Blast => m_Wrapper.m_ChapterTwo_Blast;
        public InputAction @Jump => m_Wrapper.m_ChapterTwo_Jump;
        public InputAction @Move => m_Wrapper.m_ChapterTwo_Move;
        public InputActionMap Get() { return m_Wrapper.m_ChapterTwo; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ChapterTwoActions set) { return set.Get(); }
        public void AddCallbacks(IChapterTwoActions instance)
        {
            if (instance == null || m_Wrapper.m_ChapterTwoActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ChapterTwoActionsCallbackInterfaces.Add(instance);
            @Shoot.started += instance.OnShoot;
            @Shoot.performed += instance.OnShoot;
            @Shoot.canceled += instance.OnShoot;
            @Blast.started += instance.OnBlast;
            @Blast.performed += instance.OnBlast;
            @Blast.canceled += instance.OnBlast;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IChapterTwoActions instance)
        {
            @Shoot.started -= instance.OnShoot;
            @Shoot.performed -= instance.OnShoot;
            @Shoot.canceled -= instance.OnShoot;
            @Blast.started -= instance.OnBlast;
            @Blast.performed -= instance.OnBlast;
            @Blast.canceled -= instance.OnBlast;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IChapterTwoActions instance)
        {
            if (m_Wrapper.m_ChapterTwoActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IChapterTwoActions instance)
        {
            foreach (var item in m_Wrapper.m_ChapterTwoActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ChapterTwoActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ChapterTwoActions @ChapterTwo => new ChapterTwoActions(this);
    public interface IChapterOneActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
    }
    public interface IChapterTwoActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnBlast(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
    }
}
