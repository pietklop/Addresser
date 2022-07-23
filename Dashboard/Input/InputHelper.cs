using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Messages.UI.Helpers;

namespace Dashboard.Input
{
    public static class InputHelper
    {
        public static bool GetConfirmation(Form ownerForm, string caption)
        {
            using frmInput form = new frmInput(caption, InputType.Confirmation);
            return form.ShowDialog(ownerForm) == DialogResult.OK;
        }

        public static string GetString(Form ownerForm, string caption, string defaultValue = null)
        {
            string input = null;
            using frmInput form = new frmInput(caption, InputType.String, defaultValue);
            if (form.ShowDialog(ownerForm) == DialogResult.OK)
                input = form.Input;

            return input;
        }

        public static string GetMultiLineString(Form ownerForm, string caption, string defaultValue = null)
        {
            string input = null;
            using frmMultiLineInput form = new frmMultiLineInput(caption, defaultValue);
            if (form.ShowDialog(ownerForm) == DialogResult.OK)
                input = form.Input;

            return input;
        }

        public static TimeSpan? GetTimeString(Form ownerForm, string caption, string defaultValue = null)
        {
            TimeSpan? input = null;
            using frmInput form = new frmInput(caption, InputType.Time, defaultValue);
            if (form.ShowDialog(ownerForm) == DialogResult.OK)
                input = form.Input.ParseToTimeSpan();

            return input;
        }

        /// <summary>
        /// Special match features added
        /// It will return the index when the input matches any item in the list <see cref="toMatch"/>
        /// </summary>
        public static TimeSpan? GetTimeString(Form ownerForm, string caption, List<string> toMatch, out int matchingIndex)
        {
            TimeSpan? input = null;
            matchingIndex = -1;
            using frmInput form = new frmInput(caption, InputType.Time);
            form.AllowedSpecialValues = toMatch;
            if (form.ShowDialog(ownerForm) == DialogResult.OK)
            {
                matchingIndex = toMatch.IndexOf(form.Input);
                if (matchingIndex >= 0) return null;
                input = form.Input.ParseToTimeSpan();
            }

            return input;
        }

        public static double? GetPositiveValue(Form ownerForm, string caption)
        {
            using frmInput form = new frmInput(caption, InputType.PositiveDouble);
            if (form.ShowDialog(ownerForm) != DialogResult.OK)
                return null;
            var input = double.Parse(form.Input, CultureInfo.InvariantCulture);

            return input;
        }

        public static int GetListIndex(Form ownerForm, string caption, List<string> listMembers, int? defaultIndex = null)
        {
            using var form = new frmListInput(caption, listMembers, defaultIndex);

            var widths = new List<int>();
            foreach (var listMember in listMembers)
                widths.Add(TextRenderer.MeasureText(listMember, form.CmbListFont).Width + 20);

            form.Width = Math.Max(widths.Max() + form.Width - form.CmbWidth, form.Width);

            if (form.ShowDialog(ownerForm) == DialogResult.OK)
                return form.MemberIndex;

            return -1;
        }

    }
}