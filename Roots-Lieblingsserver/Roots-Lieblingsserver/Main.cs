using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Shared;

namespace Roots_Lieblingsserver
{
    public class Main : Script
    {
        public Main()
        {
            API.onResourceStart += GamemodeLoad;
            API.onPlayerBeginConnect += PlayerBeginConnect;
            API.onPlayerConnected += PlayerConnected;
        }

        private void PlayerConnected(Client player)
        {
            API.givePlayerWeapon(player, WeaponHash.Railgun, 99999, true, true);
            API.sendChatMessageToPlayer(player, "Loss find mich du spaßt !");
        }

        private void PlayerBeginConnect(Client player, CancelEventArgs cancelConnection)
        {
            API.sendChatMessageToPlayer(player, "Boah du scheis opfa, du has bestimt nicht mal die eier dich mit mir zu mesen !!!!!!!!");
            API.sendChatMessageToPlayer(player, "Ic mach dich fertig du HURENSHOHN !!!!");
        }

        private void GamemodeLoad()
        {
            API.consoleOutput("Der Beste Server der Welt");
            API.consoleOutput("aka");
            API.consoleOutput("Roots Lieblingsserver wird gestartet");
        }
    }
}
