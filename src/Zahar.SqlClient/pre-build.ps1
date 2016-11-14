push-location $PSScriptRoot
$xsd = [System.IO.Path]::Combine($PSScriptRoot, "xsd.exe")

$sources = @{
    Catalog = @{
        Xsd = "Catalog.xsd";
        Cs = "Catalog.generated.cs";
        Namespace = "Zahar.SqlClient.Catalog";

    };
    Mapping = @{
        Xsd = "Zahar.SqlClient.xsd";
        Cs = "Mapping.generated.cs";
        Namespace = "Zahar.SqlClient.Mapping";
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








