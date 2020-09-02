using System;

namespace SBM.Models
{
    public class ErrorViewModel
    {
        //required
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public int MyPrp { get; set; }// comment
    }
}
