FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS testBuilder

# wait-for-itのインストール
RUN apt-get update && apt-get install -y --no-install-recommends wait-for-it \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/* 

# 依存関係の復元のためにcsprojファイルをdocker上にコピーしてくる
COPY "./WebApi.Kashilog.Test/WebApi.Kashilog.Test.csproj" "./tests/WebApi.Kashilog.Test.csproj"

# 依存関係の復元
RUN dotnet restore "./tests/WebApi.Kashilog.Test.csproj"

# 依存関係を復元したソースファイルをコピーしてもってくる
COPY . .

# 実行権限の付与
RUN chmod +x ./entrypoint.sh