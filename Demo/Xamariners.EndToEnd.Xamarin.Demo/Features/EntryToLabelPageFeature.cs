﻿using NUnit.Framework;
using Xamarin.UITest;
using Xamariners.EndToEnd.Xamarin.Demo.Features;
using Xamariners.EndToEnd.Xamarin.Demo.Infrastructure;

namespace Xamariners.EndToEnd.Xamarin.Demo.Features
{
    [TestFixture(Platform.Android)]
#if __Apple__
    [TestFixture(Platform.iOS)]
#endif
    public partial class EntryToLabelPageFeature : BaseLocalFeature
    {
        public EntryToLabelPageFeature(Platform platform) : base(platform)
        {
        }
    }
}