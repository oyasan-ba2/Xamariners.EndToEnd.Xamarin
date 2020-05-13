﻿using NUnit.Framework;
using Xamarin.UITest;
using Xamariners.EndToEnd.Xamarin.Features;


namespace Xamariners.EndToEnd.Xamarin.Demo.Features
{
    [TestFixture(Platform.Android)]
#if __Apple__
    [TestFixture(Platform.iOS)]
#endif
    public partial class EntryToLabelPageFeature : FeatureBase
    {
        public EntryToLabelPageFeature(Platform platform) : base(platform)
        {
            
        }
    }
}