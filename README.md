# README

## 概要
プロキシ情報を環境変数への追加、削除を行う。
主に社内?社外のネットワークの切り替え時に用いる


　
## 初期設定
本ツールと同梱する設定ファイル（SetPrpxy.exe.config）のappSettingsをユーザー環境に合わせて書き換えてください。  


例）  
```xml:App.config
<appSettings>
        <add key="proxyServer" value="****" />
        <add key="proxyPort" value="****" />
        <add key="authUser" value="****" />
        <add key="authPassword" value="****!" />
</appSettings>
```
