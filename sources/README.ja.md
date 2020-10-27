# リリースパッケージ作成方法 #

[Visual Studioを使ってビルド]

* pfxファイルは同梱していないため、以下のURLを参考に十分に長い期間の自己署名証明書を作成します。
    https://mseeeen.msen.jp/code-signing-certificate/
* Confirm-Address for Outlook.slnを開き、ソリューションエクスプローラーにて[C#]と書かれている方のプロジェクトのプロパティ→署名とたどり、前ステップで作成した自己署名証明書をClickOnceマニフェストの署名とアセンブリ署名にそれぞれ指定します。
* ソリューション構成(Debug,Release)を指定してからビルド→Confirm-Address for Outlookの発行を選択し、発行フォルダーの場所を指定します。
* 指定されたフォルダーにリリースパッケージが生成されます。

# Outlook版開発方法 #
