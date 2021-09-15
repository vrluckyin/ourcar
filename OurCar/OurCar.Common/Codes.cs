using System;
using System.Collections.Generic;
using System.Linq;

namespace OurCar.Common
{
    public enum RecordTypeCode
    {
        None,
        Deleted,
        Active,
        Approved,
        Expired,
        Processing,
        Processed,
        Success,
        Failed
    }

    public static class EnumCodes
    {
        private static readonly Dictionary<string, RecordTypeCode> _recordCodes = new Dictionary<string, RecordTypeCode>()
        {
            { "", RecordTypeCode.None },
            { "DEL", RecordTypeCode.Deleted },
            { "ACT", RecordTypeCode.Active },
            { "APD", RecordTypeCode.Approved },
            { "EXP", RecordTypeCode.Expired },
            { "PRS", RecordTypeCode.Processing },
            { "PRD", RecordTypeCode.Processed },
            { "SCD", RecordTypeCode.Success },
            { "FLD", RecordTypeCode.Failed },
        };

        private static T GetEnum<T>(string code, Dictionary<string, T> dict) where T : struct
        {
            return code != null && dict.TryGetValue(code, out T value) ? value : default(T);
        }

        private static string FromEnum<T>(T value, Dictionary<string, T> dict) where T : struct
        {
            return dict.FirstOrDefault(e => EqualityComparer<T>.Default.Equals(e.Value, value)).Key;
        }

        public static RecordTypeCode GetRecordTypeCode(string code) => GetEnum(code, _recordCodes);
        public static string FromRecordTypeCode(RecordTypeCode value) => FromEnum(value, _recordCodes);
    }
}
