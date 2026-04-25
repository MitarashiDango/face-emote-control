using MitarashiDango.AvatarUtils.Editor;
using nadena.dev.ndmf;

[assembly: ExportsPlugin(typeof(AvatarUtilsNDMFPlugin))]

namespace MitarashiDango.AvatarUtils.Editor
{
    public class AvatarUtilsNDMFPlugin : Plugin<AvatarUtilsNDMFPlugin>
    {
        protected override void Configure()
        {
            InPhase(BuildPhase.Generating)
                .BeforePlugin("nadena.dev.modular-avatar")
                .Run("Run MitarashiDango's Avatar Utils Processes", ctx => Processing(ctx));
        }

        private void Processing(BuildContext ctx)
        {
            ModifyAnimatorControllerProcess(ctx);
            FaceEmoteControlProcess(ctx);
        }

        private void ModifyAnimatorControllerProcess(BuildContext ctx)
        {
            var processor = new AnimatorControllerModifierProcessor();
            processor.Run(ctx);
        }

        private void FaceEmoteControlProcess(BuildContext ctx)
        {
            var processor = new FaceEmoteControlProcessor();
            processor.Run(ctx);
        }
    }
}