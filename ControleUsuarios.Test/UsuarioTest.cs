using System;
using System.Collections.Generic;
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

        [Theory]
        [MemberData(nameof(ListaDeUsuarios))]
        public void CamposDosUsuariosTemConteudo(Usuario usuario)
        {
            Assert.NotEmpty(usuario.Nome);
            Assert.NotEmpty(usuario.Idade.ToString());
            Assert.IsType<Usuario>(usuario);
        }

        public static IEnumerable<Object[]> ListaDeUsuarios => new[]
        {
            new [] { new Usuario { Nome = "admin", Idade = 20 }},
            new [] { new Usuario { Nome = "joão", Idade = 26 }},
            new [] { new Usuario { Nome = "raissa", Idade = 22 }},
            new [] { new Usuario { Nome = "java", Idade = 11 }},
            new [] { new Usuario { Nome = "admin2", Idade = 20 }},
        };
    }
}
