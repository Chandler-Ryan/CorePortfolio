using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CorePortfolio.Models
{
    public class ContactFormModel
    {
        [Required]
        public string Name { get; set; }

        public string Company { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }

        public string Telephone { get; set; }

        [Required]
        public string Message { get; set; }

        public bool RequestResume { get; set; } = false;

        public bool RequestFollowUp { get; set; } = false;

        public string BuildEmailBody()
        {
            var EmailBody = new StringBuilder();
            EmailBody.Append($"From: {Name} @ {Email}{Environment.NewLine}");
            if (Company != null) EmailBody.Append($"Company: {Company}{Environment.NewLine}");
            EmailBody.Append($"Subject: {Subject}{Environment.NewLine}");
            EmailBody.Append($"Date: {DateTime.Now.AddHours(2)}{Environment.NewLine}");
            if (Telephone != null)
            {
                if (Telephone.Length >= 7 && Telephone.Length <= 10)
                {
                    EmailBody.Append($"Telephone: {Telephone}{Environment.NewLine}{Environment.NewLine}");
                }

            }
            else EmailBody.Append(Environment.NewLine);
            if (RequestResume) EmailBody.Append($"{Name} is requesting a Resume{Environment.NewLine}");
            if (RequestFollowUp) EmailBody.Append($"{Name} is requesting a follow up.{Environment.NewLine}");
            EmailBody.Append($"{Environment.NewLine}{Message}");
            return EmailBody.ToString();
        }
    }
}
