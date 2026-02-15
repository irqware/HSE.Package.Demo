using HSE.Core.Processing;
using HSE.Core.Types;
using HSE.Core.Types;
using HSE.Core.Utilities;
using System;
using static HSE.Core.Utilities.StringUtilities;



namespace HSE.Package.Demo.Processing.Directives
{

   
    public class DemoInlineDirective : InlineDirectiveBase
    { 


        public DemoInlineDirective(
            HSEProcessor processor,
              string symbol,
            string[] keys )
            : base(processor,symbol,  keys    )
        {
        }

        public override async Task<bool> OnCapture(CaptureContext capture, HSEProcessorState state)
        {


            //Processor.Engine.ExecutionContext.__.WriteLine("START InlineDirective");
            //Processor.Engine.ExecutionContext.__.WriteLine("ENCLOSURE:");

            //Processor.Engine.ExecutionContext.__.WriteLine(" - " + capture.Header!.View);

            //Processor.Engine.ExecutionContext.__.WriteLine("END InlineDirective");
            if (capture.Header != null) Processor.Engine.ExecutionContext.__.WriteLine(StringUtilities.RemoveComments(capture.Header.View!).Trim()); 
            return true;
        }
           
         
    }
}
 