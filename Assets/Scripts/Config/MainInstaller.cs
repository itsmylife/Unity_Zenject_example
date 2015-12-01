using UnityEngine;
using System.Collections;
using Zenject;
using System.Linq;

public class MainInstaller : MonoInstaller
{
    public GameObject MissilePrefab;
    public GameObject TankPrefab;

    public override void InstallBindings()
    {
        Container.Bind<Tank>().ToSinglePrefab(TankPrefab);
        Container.BindGameObjectFactory<GameObjectFactory<Missile>>(MissilePrefab);

        Container.BindAllInterfacesToSingle<GameView>();
        Container.Bind<ITankController>().ToSingle<TankController>();
        Container.Bind<IMissileController>().ToSingle<MissileController>();
    }
}
