using SimpleInjector;

namespace Valkyria.Engine.Business.Ioc
{
    public static class IocContainer
    {
        private static Container s_container;

        public static Container Instance
        {
            get
            {
                if (IocContainer.s_container == null)
                    IocContainer.s_container = new Container();

                return s_container;
            }
        }
    }
}
