dotnet publish -r win-x64 -c Release --self-contained
rm -rf csrunner
mkdir csrunner
cp -r bin/Release/net5.0/win-x64/* csrunner/
tar zcvf csrunner.tgz csrunner/
