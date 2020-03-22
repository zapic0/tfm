using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XareuWFClient.Model.Commands;
using XareuWFClient.Args;

namespace XareuWFClient.Controller
{
    public class FormController
    {
        Forms.Main main;
        Controls.Tabs.ButtonTabs tabs;
        int commandNumber;

        List<Command> commands;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormController"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        /// <param name="tabs">The tabs.</param>
        public FormController(Forms.Main main, Controls.Tabs.ButtonTabs tabs)
        {
            this.main = main;
            this.tabs = tabs;
            commands = new List<Command>();
            commandNumber = 0;
        }

        /// <summary>
        /// Adds the command.
        /// </summary>
        /// <param name="command">The command.</param>
        public void AddCommand(Command command)
        {
            if (commandNumber == commands.Count)
            {
                this.commands.Add(command);
                this.commandNumber++;
            }
            else
            {
                this.commands.RemoveRange(this.commandNumber, this.commands.Count);
                this.commands.Add(command);
                this.commandNumber = this.commands.Count;
            }
            this.executeCommand(command);
        }

        /// <summary>
        /// Executes the command.
        /// </summary>
        /// <param name="command">The command.</param>
        private void executeCommand(Command command)
        {
            switch (command.Tab)
            {
                case "tags":
                    this.executeCommandTag(command);
                    break;
                case "users":
                    this.executeCommandUser(command);
                    break;
                case "groups":
                    this.executeCommandGroup(command);
                    break;
                case "publications":
                    this.executeCommandPublication(command);
                    break;
                case "controlPanel":
                    this.executeCommandControlPanel(command);
                    break;
                case "myPublications":
                    this.executeCommandMyPublications(command);
                    break;
                case "myInterests":
                    this.executeCommandMyInterests(command);
                    break;
                case "newPublications":
                    this.executeCommandNewPublications(command);
                    break;

                default:
                    break;
            }
        }

        #region Tags
        /// <summary>
        /// Executes the command tag.
        /// </summary>
        /// <param name="command">The command.</param>
        private void executeCommandTag(Command command)
        {
            TagsArgs args = ((TagsArgs)command.Args);
            if (args.Text == "" && args.Tag == null)
            {
                this.main.CreateTagsPage();
            }
            else if ((args.Tag==null) && (args.Text != ""))
            {
                this.main.OpenTagsSearch(args);
            }
            else
            {
                this.main.OpenTagsPublicationsPage(args);
            }
        }
        #endregion

        #region Users
        /// <summary>
        /// Executes the command user.
        /// </summary>
        /// <param name="command">The command.</param>
        private void executeCommandUser(Command command)
        {
            UsersArgs args = ((UsersArgs)command.Args);
            if (args.Text == "" && args.User == null)
            {
                this.main.CreateUsersPage();
            }
            else if ((args.User == null) && (args.Text != ""))
            {
                this.main.LoadUsersSearch(args);
            }
            else
            {
                this.main.LoadUserPublications(args);
            }
        }

        #endregion

        #region Groups
        /// <summary>
        /// Executes the command group.
        /// </summary>
        /// <param name="command">The command.</param>
        private void executeCommandGroup(Command command)
        {
            GroupsArgs args = ((GroupsArgs)command.Args);
            if (args.Text == "" && args.Group == null)
            {
                this.main.CreateGroupsPage();
            }
            else if ((args.Group == null) && (args.Text != ""))
            {
                this.main.LoadGroupsPage(args);
            }
            else
            {
                this.main.LoadGroupPublications(args);
            }
        }

        #endregion

        #region Publications
        /// <summary>
        /// Executes the command publication.
        /// </summary>
        /// <param name="command">The command.</param>
        private void executeCommandPublication(Command command)
        {
            PublicationArgs args = ((PublicationArgs)command.Args);
            if (args.Text == "" && args.Publication == null)
            {

            }
            else if ((args.Publication == null) && (args.Text != ""))
            {

            }
        }

        #endregion

        #region Control Panel
        /// <summary>
        /// Executes the command control panel.
        /// </summary>
        /// <param name="command">The command.</param>
        private void executeCommandControlPanel(Command command)
        {
            this.main.CreateControlPanelPage();
        }
        #endregion

        #region My Publications
        /// <summary>
        /// Executes the command my publications.
        /// </summary>
        /// <param name="command">The command.</param>
        private void executeCommandMyPublications(Command command)
        {

        }
        #endregion

        #region My Interests
        /// <summary>
        /// Executes the command my interests.
        /// </summary>
        /// <param name="command">The command.</param>
        private void executeCommandMyInterests(Command command)
        {

        }
        #endregion

        #region New Publications
        /// <summary>
        /// Executes the command new publications.
        /// </summary>
        /// <param name="command">The command.</param>
        private void executeCommandNewPublications(Command command)
        {
            this.main.CreateNewPublicationsPage(command.Args);
        }
        #endregion
    }
}
