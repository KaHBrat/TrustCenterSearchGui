﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TrustCenterSearchGui.Core.Models;

namespace TrustCenterSearchGui.Core
{
    public class Intersection
    {
        private static string FilePath { get; } =
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
            @"\TrustCenterSearch\data\";

        private static Config Config { get; set; }
        private static List<Certificate> Certificates { get; set; }

        public static void RefreshButton()
        {
            var configManager = new ConfigManager();
            Config = configManager.GetConfig();

            var downloadManager = new DownloadManager(); 
            downloadManager.DownloadDataFromConfic(Config, FilePath);

            var dataManager = new DataManager();
            Certificates = dataManager.GetCertificateFromAppData(Config, FilePath);
            dataManager.SetTimeStamp(FilePath);
        }

        public static ObservableCollection<SearchResultsAndBorder> Searcher(string search)
        {
            var searchManager = new SearchManager();
            var result = searchManager.SearchManagerConnector(search, Certificates);

            return result;
        }
    }
}