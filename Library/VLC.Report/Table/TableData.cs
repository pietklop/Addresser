using System;
using System.Collections.Generic;
using System.Linq;

namespace VLC.Report.Table
{
    public class TableData
    {
        private readonly DocBuilder doc;
        private readonly double columnSpacing;
        public double AdditionalRowHeight { get; }
        public List<ColumnDefinition> ColumnDefinitions { get; }
        /// <summary>
        /// String array per row
        /// </summary>
        public List<string[]> TextRows { get; }

        public TableData(DocBuilder doc, List<ColumnDefinition> columnDefinitions, List<string[]> textRows, double columnSpacing = 5, double additionalRowHeight = 0)
        {
            this.doc = doc;
            this.columnSpacing = columnSpacing;
            AdditionalRowHeight = additionalRowHeight;
            ColumnDefinitions = columnDefinitions;
            TextRows = textRows;
        }

        public void CalculateColumnPositions(double? x)
        {
            double definedWidth = ColumnDefinitions.Sum(c => c.InitialWidth) ?? 0;
            double totalColumnSpacing = (ColumnDefinitions.Count - 1) * columnSpacing;
            if (ColumnDefinitions.Sum(c => c.Width) + totalColumnSpacing > doc.WorkspaceWidth)
                throw new Exception($"Column-widths ({ColumnDefinitions.Sum(c => c.Width)}) + spacing sum ({totalColumnSpacing}) exceeds page workspace width ({doc.WorkspaceWidth})");

            x = x ?? doc.CurrentX;
            if (ColumnDefinitions.Any(c => !c.InitialWidth.HasValue))
            {
                double unusedWidth = doc.WorkspaceWidth - definedWidth - totalColumnSpacing;
                double colWidth = unusedWidth  / ColumnDefinitions.Count(c => !c.InitialWidth.HasValue);
                foreach (var colDef in ColumnDefinitions.Where(c => !c.InitialWidth.HasValue))
                    colDef.Width = colWidth;
            }

            ColumnDefinitions[0].XPos = x.Value;
            for (int i = 1; i < ColumnDefinitions.Count; i++)
                ColumnDefinitions[i].XPos = ColumnDefinitions[i - 1].XPos + ColumnDefinitions[i - 1].Width + columnSpacing;
        }
    }

    public class ColumnDefinition
    {
        internal double? InitialWidth;
        public double XPos { get; set; }

        public double Width
        {
            get => InitialWidth ?? 0;
            internal set => InitialWidth = value;
        }

        public DataType DataType { get; }
        public Alignment Alignment { get; }

        /// <param name="width">In case null the width will be automatically determined</param>
        /// <param name="dataType"></param>
        /// <param name="alignment"></param>
        public ColumnDefinition(double? width, DataType dataType, Alignment alignment = Alignment.Left)
        {
            if (dataType == DataType.QrCode && alignment != Alignment.Left)
                throw new InvalidOperationException($"Alignment other then {Alignment.Left} is not supported for {DataType.QrCode}");
            InitialWidth = width;
            DataType = dataType;
            Alignment = alignment;
        }
    }

    public enum DataType
    {
        String,
        QrCode,
    }
}