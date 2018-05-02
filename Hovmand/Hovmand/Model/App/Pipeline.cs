using System;

namespace Hovmand.Model.App
{
    public class Pipeline
    {
        private int _pipelineID;
        private StatusEnum _status;
        private string _information;
        private string _date;
        private string _lastEditDate;

        public Pipeline(int pipelineID, StatusEnum status, string information, string date, string lastEditDate)
        {
            _pipelineID = pipelineID;
            _status = status;
            _information = information;
            _date = date;
            _lastEditDate = lastEditDate;
        }

        public int PipelineID
        {
            get { return _pipelineID; }
            set { _pipelineID = value; }
        }

        public StatusEnum Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string Information
        {
            get { return _information; }
            set { _information = value; }
        }

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string LastEditDate
        {
            get { return _lastEditDate; }
            set { _lastEditDate = value; }
        }
    }
}