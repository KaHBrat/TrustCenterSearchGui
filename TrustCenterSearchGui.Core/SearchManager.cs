﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TrustCenterSearchGui.Core.Models;

namespace TrustCenterSearchGui.Core
{
    public class SearchManager
    {

        
        public ObservableCollection<CertificateData> SearchManagerConnecter(string search)
        {
            var searchResults = new ObservableCollection<CertificateData>() { new CertificateData { Subject = "asda", Issuer = "asodiaslk", SerialNumber = 12, NotBefore = new DateTime(2020,4,8), NotAfter = new DateTime(2021,6,3), Thumbprint = "asddsf" } };
            

            return searchResults;
        }

    }
}
