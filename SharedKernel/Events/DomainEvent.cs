using FluntSpec.SharedKernel.Containers.Contracts;
using FluntSpec.SharedKernel.Events.Contracts;
using FluntSpec.SharedKernel.Handlers.Contracts;

namespace FluntSpec.SharedKernel.Events
{
    public static class DomainEvent
    {
        public static IContainer Container { get; set; }

        public static void Raise<T>(T args) where T : IDomainEvent
        {
            try
            {
                if (Container != null)
                {
                    var obj = Container.GetService(typeof(IHandler<T>));
                    ((IHandler<T>) obj).Handle(args);
                }
            }
            catch
            {
                //throw;
            }
        }
    }
}