dotnet publish -r win-x64 -c Release -p:PublishSingleFile=true --self-contained true
mkdir csrunner
cp -r bin/Release/net5.0/win-x64/publish/* csrunner/
tar zcvf csrunner.tgz csrunner/
rm -rf csrunner
