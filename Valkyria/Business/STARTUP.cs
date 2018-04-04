using Valkyria.Engine.Business.Implementations;
using Valkyria.Engine.Business.Ioc;
using Valkyria.Engine.Business.Services;

namespace Valkyria.Engine
{
    public class STARTUP
    {
        /// <summary>
        /// Game setup method. Call this to create game state, load game objects etc.
        /// </summary>
        public void Setup()
        {
            RegisterServices();
        }

        private void RegisterServices()
        {
            var container = IocContainer.Instance;
            container.Register<ILockService, DefaultLockService>();
        }
    }
}
