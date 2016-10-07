using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QgisLayersToMapfile
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			string[] nameDatas = txtNameData.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
			string[] lines = txtQlr.Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

			var nameDataItems = parseNameData(nameDatas);
			var items = parseLines(lines);

			string mapfile="";

			foreach (Tuple<string, string> item in nameDataItems)
			{
				mapfile += itemsToMap(item.Item1, item.Item2, items);
			}
			
			txtMap.Text = mapfile;
		}

		private string itemsToMap(string name, string data, List<LegendItem> items)
		{
			string result = string.Format("LAYER\n  Projection\n    \"proj=latlong\"\n  End\n  NAME \"{0}\"\n" +
				"  Status ON\n  Type Raster\n  DATA {1}\n  OFFSITE  0 0 0\n  METADATA\n    WMS_TITLE \"{0}\"\n" +
				"    WMS_ABSTRACT \"{0}\"\n    wms_srs \"EPSG:4326\"\n  END\n", name,data);

			foreach (LegendItem legendItem in items)
			{
				result += string.Format("  CLASS\n    EXPRESSION ([pixel] >= {0} and [pixel] <={1})\n", legendItem.Min, legendItem.Max);
				result += string.Format("    STYLE\n      COLOR {0} {1} {2}\n    END\n  END\n", legendItem.Color.R, legendItem.Color.G, legendItem.Color.B);
			}

			return result + "END\n\n";
		}

		private List<Tuple<string, string>> parseNameData(string[] nameDatas)
		{
			var result = new List<Tuple<string, string>>();
			foreach (var nameData in nameDatas)
			{
				var split = nameData.Split(';');
				if (split.Length == 2)
				{
					result.Add(new Tuple<string, string>(split[0], split[1]));
				}
			}

			return result;
		}

		private List<LegendItem> parseLines(string[] lines)
		{
			var items = new List<LegendItem>();
			double? min = null;

			foreach (var line in lines)
			{
				if(string.IsNullOrEmpty(line.Trim()))
				{
					continue;
				}

				var indexOfValue = line.IndexOf("value=\"") + 7;
				var val = line.Substring(indexOfValue, line.IndexOf("\"", indexOfValue) - indexOfValue);
				if (min == null)
				{
					min = double.Parse(val);
					continue;
				}

				double max = double.Parse(val);

				var indexOfColor = line.IndexOf("color=\"#") + 8;
				var col = line.Substring(indexOfColor, line.IndexOf("\"", indexOfColor) - indexOfColor);
				int r = Convert.ToInt32(col.Substring(0, 2), 16);
				int g = Convert.ToInt32(col.Substring(2, 2), 16);
				int b = Convert.ToInt32(col.Substring(4, 2), 16);

				items.Add(new LegendItem
				{
					Min = min.Value,
					Max = max,
					Color = Color.FromArgb(r,g,b)
				});

				min = max;
			}

			return items;
		}
	}
}
