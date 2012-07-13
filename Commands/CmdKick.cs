using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCTnt.Commands
{
    class CmdKick
    {
        public override string name { get { return "kick"; } }
        public override string shortcut { get { return ""; } }
        public CmdKick() { } 
    {

        if (args.Length < 1) {
                Help(p);
                return;
    }


        Player who = Player.Find(args[0]);
        if (who == null) { p.SendMessage("Player \"" + args[0] + "\" not found!"); return; }
        if (who.Group.Permission > p.Group.Permission) { p.SendMessage("You cannot kick your superiors!"); Player.UniversalChat(p.Color + p.Username + Server.DefaultColor + " tried to kick " + who.Color + who.Username + Server.DefaultColor + " but failed!"); return; }
        if (who == p) { p.Kick(p.Username + " kicked himself!"); return; }
        if (Server.devs.ContainsIgnoreCase(who.Username)) { p.SendMessage("You cannot kick a developer!"); Player.UniversalChat(p.Color + p.Username + Server.DefaultColor + " tried to kick an MCForge developer!"); return; }
        who.Kick(kickmsg.Trim() != "" ? kickmsg : "Kicked by " + p.Username + "!");

        public void help(p.Player);
        {
            p.sendmessage("/Kick <player./IP> Kicks A Player From The Server.")
        }           
        
    }
}
