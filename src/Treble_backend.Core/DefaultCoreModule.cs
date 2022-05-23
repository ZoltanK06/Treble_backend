using Autofac;
using Treble_backend.Core.Interfaces;
using Treble_backend.Core.Services;

namespace Treble_backend.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
