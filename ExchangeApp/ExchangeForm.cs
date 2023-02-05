using BankService;
using System.ComponentModel;
using System.Globalization;
using System.Xml;

namespace ExchangeApp;
public partial class ExchangeForm : Form
{
    private BindingList<ModelValute> _allValutes = new();
    private BindingList<ModelValute> _favoritesValutes = new();

    public ExchangeForm()
    {
        InitializeComponent();
        LoadDataGrid();
        RefreshStatusStrip();
    }

    private void LoadDataGrid()
    {
        LoadValute();
        using var context = new ContextDb();
        if (_favoritesValutes.Count == 0)
        {
            ((DataGridViewButtonColumn)dataGridView.Columns["Button"]!).Text = "➕";
            exchangeTabControl.SelectedIndex = 0;
            dataGridView.Parent = allTabPage;
            dataGridView.DataSource = _allValutes;
        }
        else
        {
            ((DataGridViewButtonColumn)dataGridView.Columns["Button"]!).Text = "✖";
            exchangeTabControl.SelectedIndex = 1;
            dataGridView.Parent = favoritesTabPage;
            dataGridView.DataSource = _favoritesValutes;
        }
    }


    private void LoadValute()
    {
        var bank = new DailyInfoSoapClient(DailyInfoSoapClient.EndpointConfiguration.DailyInfoSoap);
        var response = bank.GetCursOnDateXML(DateTime.Today);

        foreach (XmlNode valute in response.ChildNodes)
        {
            var model = new ModelValute
            {
                Code = valute["VchCode"]!.InnerText,
                Name = valute["Vname"]!.InnerText.Trim(),
                Nominal = int.Parse(valute["Vnom"]!.InnerText),
                Сourse = decimal.Parse(valute["Vcurs"]!.InnerText, CultureInfo.InvariantCulture)
            };

            _allValutes.Add(model);
        }

        LoadFavoriteValute();
    }

    private void LoadFavoriteValute()
    {
        _favoritesValutes.Clear();
        using var context = new ContextDb();
        var codes = context.Favorites.Select(x => x.Code);
        var valutes = _allValutes.Where(x => codes.Contains(x.Code));
        foreach (var valute in valutes)
        {
            _favoritesValutes.Add(valute);
        }
    }

    private void exchangeTabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (exchangeTabControl.SelectedIndex)
        {
            case 0:
                ((DataGridViewButtonColumn)dataGridView.Columns["Button"]!).Text = "➕";
                dataGridView.Parent = allTabPage;
                dataGridView.DataSource = _allValutes;
                break;
            case 1:
                ((DataGridViewButtonColumn)dataGridView.Columns["Button"]!).Text = "✖";
                dataGridView.Parent = favoritesTabPage;
                dataGridView.DataSource = _favoritesValutes;
                break;
        }

        RefreshStatusStrip();
    }

    private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (dataGridView.Columns[e.ColumnIndex] is not DataGridViewButtonColumn) return;

        var row = e.RowIndex;
        var code = (string)dataGridView[1, row].Value;
        using var context = new ContextDb();

        switch (exchangeTabControl.SelectedIndex)
        {
            case 0:
                //добавление в избранное (занесение в бд)
                if (context.Favorites.Find(code) == null)
                {
                    context.Add(new FavoriteValute(code));
                }
                break;
            case 1:
                //удаление из избранного (удаление из бд)
                context.Favorites.Remove(context.Favorites.First(x => x.Code == code));
                RefreshStatusStrip();
                break;
        }

        context.SaveChanges();
        LoadFavoriteValute();
    }

    private void RefreshStatusStrip()
    {
        statusStrip.Items[0].Text = $@"Курс для {dataGridView.RowCount} валют";
    }
}