﻿#if FALSE

using Jamcast2;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace Jamcast
{
    public class TrayIcon
    {
        private NotifyIcon m_NotifyIcon = null;
        private Manager m_Manager = null;

        public TrayIcon(Manager manager)
        {
            this.m_Manager = manager;

            // Create the container.
            IContainer container = new Container();

            // Create the notify icon.
            m_NotifyIcon = new NotifyIcon(container)
            {
                //Icon = Resources.TrayOff,
                Text = "JamCast Client - " + manager.User,
                Visible = true
            };
            this.m_NotifyIcon.DoubleClick += new EventHandler(item_Click);
        }

        public Icon Icon
        {
            get { return this.m_NotifyIcon.Icon; }
            set { this.m_NotifyIcon.Icon = value; }
        }

        void item_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

#endif