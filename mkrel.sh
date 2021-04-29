reldir=yy.out
rm -rf bin
rm -rf $reldir
mkdir $reldir
dotnet.exe publish -r win-x64 -c Release --self-contained
mv bin/netcoreapp3.1/win-x64/* $reldir

