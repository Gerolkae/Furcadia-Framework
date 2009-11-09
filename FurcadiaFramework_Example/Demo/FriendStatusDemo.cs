﻿using System;
using System.Collections.Generic;
using System.Text;
using Furcadia.Net;
using System.Windows.Forms;

namespace FurcadiaFramework_Example.Demo
{
    public class FriendStatusDemo : IDemo
    {
        private delegate void Invoker();
        PounceConnection pounce;
        public FriendStatusDemo()
        {

        }
        #region IDemo Members

        public void Run()
        {
            pounce = new PounceConnection("http://on.furcadia.com/", null);
            Form f = new Form();
            f.Text = "Frind Status Checkr (Misspelled Version)";
            f.AutoScroll = true;
            f.Width = 200;
            f.Height = 150;

            SplitContainer container = new SplitContainer();
            container.Orientation = Orientation.Horizontal;
            container.Dock = DockStyle.Fill;
            container.SplitterDistance = 15;
            RichTextBox statusBox = new RichTextBox();
            statusBox.Top = 15;
            statusBox.ReadOnly = true;
            statusBox.Dock = DockStyle.Fill;

            TextBox input = new TextBox();
            input.Dock = DockStyle.Top;
            input.KeyDown += delegate(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Enter)
                {
                    pounce.ClearFriends();
                    foreach (string friend in input.Text.Split(','))
                        pounce.AddFriend(friend);
                    pounce.Connect();
                }
                
            };

            pounce.Response += delegate(string[] friends)
            {
                foreach (string friend in friends)
                {
                    if (statusBox.InvokeRequired)
                        statusBox.Invoke(new Invoker(delegate
                        {
                            statusBox.AppendText(friend + " is Online!\n");
                        }));
                }
                pounce.ClearFriends();
                pounce.Kill();
            };
            f.HelpButton = true;
            f.HelpRequested += delegate
            {
                MessageBox.Show("Type into the box the names separated by a comma (,) [i.e Bob, Charlie|Omega, Bill]");
            };
            f.HelpButtonClicked += delegate
            {
                MessageBox.Show("Type into the box the names separated by a comma (,) [i.e Bob, Charlie|Omega, Bill]");
            };
            container.Panel1.Controls.Add(input);
            container.Panel2.Controls.Add(statusBox);
            f.Controls.Add(container);
            MessageBox.Show("FriendStatusDemo: Hit F1 at anytime for another popup like this with instructions.");
            f.ShowDialog();
        }

        #endregion
    }
}