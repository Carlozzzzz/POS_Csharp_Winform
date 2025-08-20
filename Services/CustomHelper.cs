using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_V1.Services
{
    public static class CustomHelper
    {
        public static MessageBoxIcon GetMessageBoxIcon(string messageType)
        {
            if (string.IsNullOrWhiteSpace(messageType))
                return MessageBoxIcon.None;

            switch (messageType.Trim().ToLower())
            {
                case "error":
                case "danger":
                case "fail":
                    return MessageBoxIcon.Error;

                case "warning":
                case "alert":
                    return MessageBoxIcon.Warning;

                case "information":
                case "info":
                case "notice":
                    return MessageBoxIcon.Information;

                case "question":
                case "confirm":
                case "ask":
                    return MessageBoxIcon.Question;

                case "success":
                case "ok":
                case "done":
                    // No direct Success icon in WinForms → fallback to Information
                    return MessageBoxIcon.Information;

                default:
                    return MessageBoxIcon.None;
            }
        }
    }
}
