using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400130
{
    internal class BankTransferConfig
    {
        public string lang {  get; set; }
        public int transfer {  get; set; }
        public string methods { get; set; }
        public string confirmation { get; set; }

        private const string filePath = "bank_transfer_config.json";

        public BankTransferConfig() {
            {
                        "lang": "en",
          "transfer": {
                            "threshold": "25000000",
            "low_fee": "6500",
            "high_fee": "15000"
          },
          "methods": "[ “RTO (real-time)”, “SKN”, “RTGS”, “BI FAST” ]",
          "confirmation": {
                            "en": "yes",
            "id": "ya"
          }
            }
        }
    }
}
