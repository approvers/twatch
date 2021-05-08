# 🔍 Twatch
Watches Twitter statuses with a keyword, and reports them to Discord.

## ✅ Prerequisites
One of these:
- .NET 5.x
- Docker 20.10.x

## 📦 Installation
### 🐳 with Docker
```
$ docker run ghcr.io/approvers/twatch:latest
```

### 🐬 On-premise
```
$ git clone https://github.com/approvers/twatch.git
$ cd twatch/Twatch
$ dotnet publish -c Release -o out
$ dotnet ./out/Twatch.dll
```

## 🔧 Configuration
Write **appsettings.local.json** to configure the application.
Optionally refer **appsettings.json** for example.
On Docker, use attach it as volume mounted to `/app/appsettings.local.json` .

- (root)
    - **Twitter**: Configurations for Twitter.
        - **ConsumerKey:** Your consumer key for Twitter API.
        - **ConsumerSecret:** Your consumer secret.
        - **AccessToken:** This application requires user-scoped token.
        - **AccessTokenSecret:** ... and secret.
        - **Keyword**: A keyword to watch about.
    - **Discord**: Configurations for Discord.
        - **WebhookUrl**: The URL to Webhook of the channel.

---
Made with 💕 in Matsudo, Chiba, Japan  
&copy; 2021 Naoki Ikeguchi, Approvers.
