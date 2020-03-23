﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TrustCenterSearchGui.Core.Models;

namespace TrustCenterSearchGui.Presentation
{
    public class ViewModel : ViewModelBase
    {
        public ViewModel()
        {
            if (base.IsInDesignMode)
            {
                CertificateSearchResultList.Add(new CertificateData()
                {
                    Issuer = "Issuer"
                } );

                this.Search = "My search";
            }
        }

        private string search;
        public string Search 
        { 
            get => this.search;
            set
            {
                base.Set(ref this.search, value);
                this.SearchCalcuclation();
            }
        }

        private ObservableCollection<CertificateData> certificateSearchResultList = new ObservableCollection<CertificateData>();
        public ObservableCollection<CertificateData> CertificateSearchResultList
        { 
            get => this.certificateSearchResultList; 
            set => base.Set(ref this.certificateSearchResultList, value);
        }

        private void SearchCalcuclation()
        {
            var Search = new Core.SearchManager();
            var searchResults = Search.SearchManagerConnecter(this.Search);

            this.CertificateSearchResultList = searchResults;

        }

    }
}
