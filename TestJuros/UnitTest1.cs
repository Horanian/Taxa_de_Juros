using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxaJuros.Controllers;
[TestClass]
public class JurosControllerTest
{
    /// <summary>
    /// testando o juros
    /// </summary>
    /// 
    [TestMethod]
    public void GetJuros_RetornaValorCorreto()
    {
        // Arrange
        var controller = new JurosController();
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

        // Act
        var result = controller.GetJuros();

        // Assert
        Assert.AreEqual("0.01", result.Value);
    }

}
