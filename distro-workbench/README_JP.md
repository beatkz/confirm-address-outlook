# 7-zipを用いたインストーラーの作成方法

下記の手順をまとめたバッチファイルは[こちら](mkdistropkg.cmd)

## 必要なもの

- [7-Zip](https://7-zip.opensource.jp/)  
リンク先は7-Zip公式サイト。リンク先からインストーラーをDLか、下記のコマンドでインストール可能。(要アプリインストーラー)  
`winget install 7zip.7zip --silent`

- [7zSD.sfx on Github](https://github.com/git-for-windows/build-extra/tree/main/7-Zip)  
GUI版インストーラー用自己解凍モジュール。

- UTF-8が編集できるテキストエディター  
7zSDconfig.txtを編集する際に使用する。

## 作り方

1. Confirm-Addressのバージョン番号を変更し、発行する。

    - sources\Confirm-Address for Outlook 2013\bin 配下の全ファイルを削除する
    - ソリューションエクスプローラーからConfirm-Address for Outlookプロジェクトを右クリック→プロパティを選択
    - 公開→公開するバージョンを必要に応じて書き換える
    - 公開フォルダーの場所(FTPサーバーまたはファイルパス)を`distro-workbench\dest`に設定し、[今すぐ公開]をクリック

2. 展開したいファイル・プログラム群を7zipで圧縮する

    - requireフォルダーのconfirm-address.cerおよび、setup.cmdをdestフォルダーにコピーする。
    - destフォルダーに移動してCtrl+Aで選択してから右クリック→7-zip→圧縮する。
    - ファイル名はarchive.7zとしてdistro-workbenchに置く。

3. 7zSDconfig.txtを作成する

    簡易インストーラーに対しての設定ファイルをUTF-8形式で作成する。

    ```TEXT
    ;!@Install@!UTF-8!
    Title="Confirm-Address for Outlook Classicのインストール"
    Directory="C:\\Utils\\C-AOutlook"
    InstallPath="C:\\Utils\\C-AOutlook"
    BeginPrompt="プログラムのインストールを開始します。"
    ExecuteFile="setup.cmd"
    ;!@InstallEnd@!
    ```

    書けたら7zSDconfig.txtと名前を付けて保存する。

4. exe化する

    - 3.までの作業でフォルダー構造はこのようになっている。

    ```TEXT
    distro-workbench/
        dest/
            Application Files/
                Confirm-AddressforOl_x_y_z_r/
                    (VSTOアドインのモジュールファイル群)
            confirm-address.cer
            Confirm-AddressForOl.vsto
            setup.cmd
            setup.exe
        require/
            7zSD.sfx
            7zSDconfig.txt
            confirm-address.cer
            setup.cmd
        archive.7z
        mkdistropkg.cmd
        README_JP.md(このファイル)
    ```

    - distro-workbenchフォルダーのアドレス欄にcmdと入力してコマンドプロンプトを起動する
    - 下記コマンドを実行すると3ファイルを連結し、exeファイルが作成される。  
    `copy /b require\7zSD.sfx + require\7zSDconfig.txt + archive.7z Confirm-AddressOutlookSetupvxyz.exe`
