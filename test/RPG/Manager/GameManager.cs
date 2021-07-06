using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class GameManager : Manager<GameManager>
    {
        public Player player;
        public List<NPC> npcs;

        public const string gameName = "PP's Father and Balloons";
        /// <summary>
        /// 注册玩家
        /// </summary>
        /// <param name="player">玩家对象</param>
        public void RegistPlayer(Player player)
        {
            this.player = player;
        }
        /// <summary>
        /// 新增NPC
        /// </summary>
        /// <param name="npc">NPC对象</param>
        public void AddNPC(NPC npc)
        {
            if (!npcs.Contains(npc))
            {
                npcs.Add(npc);
            }
        }
        /// <summary>
        /// 移除NPC
        /// </summary>
        /// <param name="npc">NPC对象</param>
        public void RemoveNPC(NPC npc)
        {
            if (npcs.Contains(npc))
            {
                npcs.Remove(npc);
            }
        }
        /// <summary>
        /// 初始化所有NPC
        /// </summary>
        public void InitAllNPC()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public void PlayerDead()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public void Player()
        {

        }
    }
}
