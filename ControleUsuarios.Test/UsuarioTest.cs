using System;
using Xunit;

namespace ControleUsuarios.Test
{
  public class UsuarioTest
  {
    [Fact]
    public void deveRetornarVerdadeiroQuandoMaiorIdade()
    {
      // Arrange
      var usuario = new Usuario("João", 19);
      var esperado = true;

      // Act
      var resultado = usuario.maiorDeIdade();

      // Assert
      Assert.Equal(esperado, resultado);
    }

    [Fact]
    public void deveRetornarFalsoQuandoMenorIdade()
    {
      // Arrange
      var usuario = new Usuario("Marcio", 16);
      var esperado = false;

      // Act
      var resultado = usuario.maiorDeIdade();

      // Assert
      Assert.Equal(esperado, resultado);
    }
  }
}
