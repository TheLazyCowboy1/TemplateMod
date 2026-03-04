using System;
using System.Security;
using System.Security.Permissions;
using BepInEx;
using EasyModSetup;

#pragma warning disable CS0618

[module: UnverifiableCode]
[assembly: SecurityPermission(SecurityAction.RequestMinimum, SkipVerification = true)]

namespace TemplateMod;

[BepInPlugin("LazyCowboy.TemplateMod", "TemplateMod Name", "0.0.1")]
public class Plugin : SimplerPlugin
{

    #region Setup
    public override int LogLevel => Options.LogLevel;

    public Plugin() : base(new Options())
    {
    }


    #endregion

    #region Hooks

    public override void ApplyHooks()
    {
    }

    public override void RemoveHooks()
    {
    }

    #endregion

}
