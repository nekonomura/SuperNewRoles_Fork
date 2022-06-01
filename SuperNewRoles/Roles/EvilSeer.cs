using SuperNewRoles.CustomOption;
using SuperNewRoles.CustomRPC;
using SuperNewRoles.Patch;
using System;
using System.Collections.Generic;
using System.Text;
using SuperNewRoles.Mode;

namespace SuperNewRoles.Roles
{
    class EvilSeer
    {

        public static List<byte> DeathFlashList;
        public static bool DeathFlash(PlayerControl p)
        {
            if (ModeHandler.isMode(ModeId.SuperHostRoles))
            {
                if (!RoleClass.EvilSeer.ShiNoTenmetsu) return false;
                if (!p.isRole(RoleId.EvilSeer)) return false;
                if (DeathFlashList.Contains(p.PlayerId)) return true;

                SuperNewRolesPlugin.Logger.LogInfo("有効か(EvilSeer):" + (RoleClass.EvilSeer.ShiNoTenmetsu == true));
                if (RoleClass.EvilSeer.ShiNoTenmetsu == true)
                {
                    SuperNewRolesPlugin.Logger.LogInfo("有効を返しました(EvilSeer.cs)");
                    return true;
                }
                // SuperNewRolesPlugin.Logger.LogInfo("一番下まで通過");                
            }
            return false;
        }
    }
}
