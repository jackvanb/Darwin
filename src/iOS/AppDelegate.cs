using Foundation;
using UIKit;
using Amazon;
using Amazon.Util;

namespace Darwin.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{  
      public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
			// AWS Credentials
			var loggingConfig = AWSConfigs.LoggingConfig;
            loggingConfig.LogMetrics = true;
            loggingConfig.LogResponses = ResponseLoggingOption.Always;
            loggingConfig.LogMetricsFormat = LogMetricsFormatOption.JSON;
            loggingConfig.LogTo = LoggingOptions.SystemDiagnostics;

			AWSConfigs.AWSRegion = "us-east-1";

			AWSHttpClient client;


            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
