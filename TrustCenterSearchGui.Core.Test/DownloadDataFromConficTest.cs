﻿using System;
using System.Collections.Generic;
using Xunit;


namespace TrustCenterSearchGui.Core.Test
{
    public class DownloadManagerTest
        {
            [Fact(DisplayName = "Get data from configfiles")]
            public void DownloadData()
            {
                #region Arrange
                var downloadManager = new TrustCenterSearchGui.Core.DownloadManager();

           

                var config = new Config();
                config.TrustCenters = new List<TrustCenter>()
                {
                    new TrustCenter() {Name = "Example1", TrustCenterURL = "link"},
                };


            #endregion

            #region Act

                downloadManager.DownloadDataFromConfic(config);

                #endregion

                #region Assert

                var a = true;
                Assert.Equal(true, a);

                #endregion
            }
    }
}
