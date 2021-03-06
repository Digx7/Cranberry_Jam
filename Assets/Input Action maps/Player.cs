// GENERATED AUTOMATICALLY FROM 'Assets/Input Action maps/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""97e9a314-8433-468c-a32a-7837a08976e9"",
            ""actions"": [
                {
                    ""name"": ""Move Player 01"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c30c87c2-7ad9-4c6e-a98c-3b7290428669"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move Player 02"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b7d38709-f4ad-4db1-ab8a-019f151da29a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""93f1f977-e8b2-4366-880d-324c4feb3b04"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Player 01"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""97ddff84-8537-4678-b940-0fffc59b4dde"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Player 01"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""969e650a-6aef-4bc8-bdb3-ea01da463062"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Player 01"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ac334001-4417-4fe9-aa3d-28ef20956ac6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Player 01"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""62740165-7220-4841-9c32-a06669532365"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Player 01"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""db2082af-d92f-4af6-b25b-4d692d55289c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Player 01"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6a6ddaab-475e-4b57-bcf4-b64f017e77ec"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Player 02"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""6a504728-123d-41bf-91d4-0045781bb012"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Player 02"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1d49c1ab-7f4a-4832-ba3f-31fa63dffd33"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Player 02"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ff0e409e-4170-4514-8b39-0df939f2bc87"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Player 02"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""027cad46-d0e8-4a29-b9a1-5eacd568e41a"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Player 02"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""68299873-5da8-4b28-8972-8f29ecda5467"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Player 02"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Menus"",
            ""id"": ""b3d2b32a-45af-4824-ac11-c234e1c63fc4"",
            ""actions"": [
                {
                    ""name"": ""Scroll"",
                    ""type"": ""Value"",
                    ""id"": ""cc556658-72e6-4f9a-9ba5-25eacd20f4ff"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fa0c6be0-4e94-4a37-a21f-dfd64afd2bc8"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Scroll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_MovePlayer01 = m_Main.FindAction("Move Player 01", throwIfNotFound: true);
        m_Main_MovePlayer02 = m_Main.FindAction("Move Player 02", throwIfNotFound: true);
        // Menus
        m_Menus = asset.FindActionMap("Menus", throwIfNotFound: true);
        m_Menus_Scroll = m_Menus.FindAction("Scroll", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private IMainActions m_MainActionsCallbackInterface;
    private readonly InputAction m_Main_MovePlayer01;
    private readonly InputAction m_Main_MovePlayer02;
    public struct MainActions
    {
        private @Player m_Wrapper;
        public MainActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @MovePlayer01 => m_Wrapper.m_Main_MovePlayer01;
        public InputAction @MovePlayer02 => m_Wrapper.m_Main_MovePlayer02;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void SetCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterface != null)
            {
                @MovePlayer01.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMovePlayer01;
                @MovePlayer01.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMovePlayer01;
                @MovePlayer01.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMovePlayer01;
                @MovePlayer02.started -= m_Wrapper.m_MainActionsCallbackInterface.OnMovePlayer02;
                @MovePlayer02.performed -= m_Wrapper.m_MainActionsCallbackInterface.OnMovePlayer02;
                @MovePlayer02.canceled -= m_Wrapper.m_MainActionsCallbackInterface.OnMovePlayer02;
            }
            m_Wrapper.m_MainActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MovePlayer01.started += instance.OnMovePlayer01;
                @MovePlayer01.performed += instance.OnMovePlayer01;
                @MovePlayer01.canceled += instance.OnMovePlayer01;
                @MovePlayer02.started += instance.OnMovePlayer02;
                @MovePlayer02.performed += instance.OnMovePlayer02;
                @MovePlayer02.canceled += instance.OnMovePlayer02;
            }
        }
    }
    public MainActions @Main => new MainActions(this);

    // Menus
    private readonly InputActionMap m_Menus;
    private IMenusActions m_MenusActionsCallbackInterface;
    private readonly InputAction m_Menus_Scroll;
    public struct MenusActions
    {
        private @Player m_Wrapper;
        public MenusActions(@Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Scroll => m_Wrapper.m_Menus_Scroll;
        public InputActionMap Get() { return m_Wrapper.m_Menus; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenusActions set) { return set.Get(); }
        public void SetCallbacks(IMenusActions instance)
        {
            if (m_Wrapper.m_MenusActionsCallbackInterface != null)
            {
                @Scroll.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnScroll;
                @Scroll.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnScroll;
                @Scroll.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnScroll;
            }
            m_Wrapper.m_MenusActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Scroll.started += instance.OnScroll;
                @Scroll.performed += instance.OnScroll;
                @Scroll.canceled += instance.OnScroll;
            }
        }
    }
    public MenusActions @Menus => new MenusActions(this);
    public interface IMainActions
    {
        void OnMovePlayer01(InputAction.CallbackContext context);
        void OnMovePlayer02(InputAction.CallbackContext context);
    }
    public interface IMenusActions
    {
        void OnScroll(InputAction.CallbackContext context);
    }
}
