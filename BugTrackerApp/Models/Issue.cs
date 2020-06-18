﻿////////////////////////////////////////////////////////////////////////////////////////////////////
/// <file>  BugTrackerApp\Models\Issue.cs </file>
///
/// <copyright file="Issue.cs" company="Dawid Osuchowski">
/// Copyright (c) 2020 Dawid Osuchowski. All rights reserved.
/// </copyright>
///
/// <summary>   Implements the issue class. </summary>
////////////////////////////////////////////////////////////////////////////////////////////////////

using System;

namespace BugTrackerApp.Models
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   An issue. </summary>
    ///
    /// <remarks>   Dawid, 18/06/2020. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class Issue
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the identifier. </summary>
        ///
        /// <value> The identifier. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public long Id { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the number of Issue. </summary>
        ///
        /// <value> The number. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int Number { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the title. </summary>
        ///
        /// <value> The title. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Title { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the body. </summary>
        ///
        /// <value> The body. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Body { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the status. </summary>
        ///
        /// <value> The status. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Status { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the Date/Time of the created at. </summary>
        ///
        /// <value> The created at. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public DateTime CreatedAt { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the comments. </summary>
        ///
        /// <value> The comments. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public int Comments { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the user. </summary>
        ///
        /// <value> The user. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public User User { get; set; }
    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A post issue. </summary>
    ///
    /// <remarks>   Dawid, 18/06/2020. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    public class PostIssue
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the title. </summary>
        ///
        /// <value> The title. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Title { get; set; }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets or sets the body. </summary>
        ///
        /// <value> The body. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public string Body { get; set; }
    }
}