#if OXIDE

using JetBrains.Annotations;
using Oxide.Core;
using Oxide.Core.Extensions;

namespace Oxide.Ext.ConsoleExt;

[UsedImplicitly]
public class ConsoleExt : Extension
{
    public override string Name => "ConsoleExt";
    public override string Author => "Ilovepatatos";
    public override VersionNumber Version => new(1, 1, 1);

    public override bool SupportsReloading => true;

    public ConsoleExt(ExtensionManager manager) : base(manager) { }

    public override IEnumerable<string> GetPreprocessorDirectives()
    {
        yield return "CONSOLE_FRAMEWORK";
    }
}

#endif