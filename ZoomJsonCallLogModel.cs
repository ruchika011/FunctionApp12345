using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp12345
{
    public class ZoomJsonCallLogModel
    {
        public string next_page_token { get; set; }
        public int page_size { get; set; }
        public int total_records { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public List<CallLog> call_logs { get; set; }
    }
    public class CallLog
    {
        public string id { get; set; }
        public string call_type { get; set; }
        public string caller_number { get; set; }
        public int caller_number_type { get; set; }
        public string caller_number_source { get; set; }
        public string callee_number { get; set; }
        public int callee_number_type { get; set; }
        public string callee_name { get; set; }
        public string direction { get; set; }
        public int duration { get; set; }
        public string result { get; set; }
        public DateTime date_time { get; set; }
        public string path { get; set; }
        public SiteJson site { get; set; }
        public bool has_recording { get; set; }
        public bool has_voicemail { get; set; }
        public string call_id { get; set; }
        public OwnerJson owner { get; set; }
        public string caller_country_code { get; set; }
        public string caller_country_iso_code { get; set; }
        public string caller_billing_reference_id { get; set; }
        public string callee_did_number { get; set; }
        public string callee_country_code { get; set; }
        public string callee_country_iso_code { get; set; }
        public string department { get; set; }
        public string charge { get; set; }
        public string client_code { get; set; }
        public string device_private_ip { get; set; }
        public string device_public_ip { get; set; }
        public string rate { get; set; }
        public string recording_id { get; set; }
        public string recording_type { get; set; }
        public string cost_center { get; set; }
        public string caller_name { get; set; }
        public string callee_number_source { get; set; }
        public string caller_did_number { get; set; }
        public DateTime? call_end_time { get; set; }
        public string from { get; set; }
        public string user_id { get; set; }
        public int hold_time { get; set; }
        public int waiting_time { get; set; }
        public DateTime? answer_start_time { get; set; }
    }

    public class OwnerJson
    {
        public string type { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public int extension_number { get; set; }
    }

    public class SiteJson
    {
        public string id { get; set; }
        public string name { get; set; }
    }
}
