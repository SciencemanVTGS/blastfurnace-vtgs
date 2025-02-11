using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Config;
using Vintagestory.API.Server;
using Vintagestory.GameContent;

namespace BlastFurnace.src
{
    public class BlastFurnaceModSystem : ModSystem
    {


        public override void Start(ICoreAPI api)
        {
            api.RegisterBlockEntityClass("BEBlastFurnace", typeof(BlockEntityBEBlastFurnace));
            api.RegisterBlockClass("BlockBlastFurnace", typeof(BlockBlastFurnace));
        }

        public override void StartServerSide(ICoreServerAPI api)
        {
            base.StartServerSide(api);
            api.Network.RegisterChannel("timeswitch");
        }


    }
}
