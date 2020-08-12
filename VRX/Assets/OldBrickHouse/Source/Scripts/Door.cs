﻿using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] public string ObjectName;

    void Start()
    {

    }

    void Update()
    {

    }

    #region On Hover

    public HoverOutput Hover()
    {
        return new HoverOutput
        {
            ObjectName = ObjectName
        };
    }

    #endregion

    #region On Interact

    public InteractionOutput Interact()
    {
        OpenFrontDoor();

        return new InteractionOutput
        {
            ObjectName = ObjectName,
        };
    }

    #endregion

    #region Animations

    public void OpenFrontDoor()
    {
        Animator animator = this.GetComponent<Animator>();

        if (animator != null)
        {
            bool shouldOpen = animator.GetBool("Open");

            animator.SetBool("Open", !shouldOpen);
        }
    }
    
    #endregion
}




//using UnityEngine;
//using System.Collections;

//namespace OldBrickHouse
//{

//    [RequireComponent(typeof(Collider))]
//    [RequireComponent(typeof(MeshFilter))]
//    public class Door : MonoBehaviour
//    {

//        public bool isItOpen = false;
//        public bool thisIsGate = false;

//        //Used to identify door types. enum names match mesh names in scene. If 'thisIsGate' checked, door enum is ignored and gate type is used instead.

//        public enum ID
//        {
//            Front_Door,
//            Backdoor,
//            Trapdoor,
//            Door_Interior,
//            Door_Interior_02,
//            Door_Interior_03,
//            Door_Interior_04,
//            Door_Interior_05,
//            Door_Interior_06,
//            Door_Interior_07,
//            Window_Attic_01,
//            Window_Attic_02
//        }

//        public enum gates
//        {
//            Small_Gate,
//            Large_Gate_01,
//            Large_Gate_02
//        }

//        public ID doorType;
//        public gates gateType;

//    }
//}
