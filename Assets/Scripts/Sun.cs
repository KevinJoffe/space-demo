using UnityEngine;
using Zenject;

public class Sun : MonoBehaviour
{
    public class Factory : Factory<Sun>
    {
    }
}