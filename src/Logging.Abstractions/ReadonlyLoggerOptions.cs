﻿namespace WD.Logging.Abstractions
{
    public class ReadonlyLoggerOptions
    {
        /// <summary>
        /// File name for logging
        /// </summary>
        public virtual string FileName { get; protected set; }

        /// <summary>
        /// Are the archived log files archived
        /// </summary>
        public virtual bool IsCompressed { get; protected set; }

        /// <summary>
        /// Current log level
        /// </summary>
        public virtual LogLevel Level { get; protected set; } = LogLevel.Off;

        /// <summary>
        /// Max count for archive files
        /// </summary>
        public virtual int ArchiveCount { get; protected set; } = 5;

        /// <summary>
        /// Max file size before archive
        /// </summary>
        public virtual FileSize SizePerFile { get; protected set; }

        /// <summary>
        /// Create new log file on start and archive privious (also if the file size lower than max file size)
        /// </summary>
        public virtual bool IsArchiveOnStart { get; protected set; }

        /// <summary>
        /// Log filter
        /// </summary>
        public virtual string Filter { get; protected set; } = "*";
    }
}
