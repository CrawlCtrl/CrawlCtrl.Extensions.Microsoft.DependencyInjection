using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace CrawlCtrl.Extensions.Microsoft.DependencyInjection.Test;

public sealed class DependencyInjectionTests
{
    [Fact]
    public void WHEN_Adding_CrawlCtrl_dependencies_THEN_Dependency_graph_is_valid()
    {
        // Arrange
        var serviceCollection = new ServiceCollection();

        // Act
        serviceCollection.AddCrawlCtrl();
        
        // Assert
        serviceCollection.BuildServiceProvider(new ServiceProviderOptions
        {
            ValidateScopes = true,
            ValidateOnBuild = true
        });
    }
}