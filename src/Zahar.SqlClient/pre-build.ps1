push-location $PSScriptRoot
$xsd = [System.IO.Path]::Combine($PSScriptRoot, "xsd.exe")

$sources = @{
    Catalog = @{
        Xsd = "DbCatalogQueryResult.xsd";
        Cs = "DbCatalogQueryResult.generated.cs";
        Namespace = "Zahar.SqlClient";

    };
    Mapping = @{
        Xsd = "Selectors.xsd";
        Cs = "Selectors.generated.cs";
        Namespace = "Zahar.SqlClient";
    };
};

$sources.Keys | foreach{
    $info = $sources[$_]
    $info.Temp = $info.Xsd -replace "\W(?!xsd$)", "_" -replace "xsd$", "cs"
    $info.Xsd = [System.IO.Path]::Combine($PSScriptRoot, $info.Xsd)
    $info.Cs = [System.IO.Path]::Combine($PSScriptRoot, $info.Cs)
    $info.Temp = [System.IO.Path]::Combine($PSScriptRoot, $info.Temp)
    $ns = $info.Namespace
    
    & $xsd $info.Xsd "/c", "/o:`"$resourcesDir`"", "/n:`"$ns`""
    Move-Item -Path $info.Temp -Destination $info.Cs -Force

}








