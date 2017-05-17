using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PMSystem.Entities
{
    public class MailboxEntry
    {
        public MailboxEntry()
        { }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string From { get; set; }

        public ProjectMailbox ProjectMailbox { get; set; }

        public Project Project { get; set; }

        public int IssueId { get; set; }

        [XmlIgnore]
        public ArrayList MailAttachments = new ArrayList();

        public int AttachmentsSavedCount { get; set; }

        public bool WasProcessed { get; set; }

        public string ProcessingMessage { get; set; }

        public bool IsHtml { get; set; }
    }
}
