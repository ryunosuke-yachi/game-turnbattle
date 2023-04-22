# game-turnbattle
ここにゲームの簡単な概要を記入

# 全員必読！！
## READMEについて
- チーム全体での認識の統一と情報の共有としてとりあえず使います
- つかいかたがよくわからなくて、なにかあれば追記するのでTeamsのチャットなどで共有よろしく
- 殴り書きしたので今後見やすいように編集します

## READMEなどの編集方法
- 右側についてる「・・・」から「Edit」を選択

## マークダウン記法について
GitHubではマークダウン記法という特殊な書き方をするので、簡単な使い方をテンプレとしてまとめるのでつかってね

- 段落の作り方
- #で段落が作れます、複数つけることで小さな段落になるのでうまく使おう
~~~
# ここに入力(#の後には半角スペースを付ける)
~~~

~~~
## ここに入力(つければつけるほど小さな段落になる)
~~~

- 箇条書きについて
- -で箇条書きにできます
~~~
- ここに入力(-の後には半角スペースを付ける)
~~~

- チェックボックスについて
- [ ] ←こんな感じでチェックボックスが作れます

~~~
- [ ] ここに入力(-[ ]の後には半角スペースを付ける)
~~~

- テンプレート作成について
- コピーが簡単にできます
~~~
~~ ~
ここに入力(使う際は~~~と3つつなげてください)
~~ ~

~~~

- リンクについて
- 直接リンクははれますが、[こんなかんじで](https://notepm.jp/help/how-to-markdown)こっちのほうが見やすいので一応
~~~
[ここにタイトル](ここにurl)
~~~

代表的なのはこれくらいで、まだまだほかにもあるので興味があれば後学のために[こちら](https://notepm.jp/help/how-to-markdown)から

# プログラマー必読！！
issueを切ってから作業をお願いします

## 概要
- 将来的にもissueでのタスク管理ができるといいよねってことで使ってみようというだけ
- 本来wikiっていう項目に作るんだけど無償だとwiki使えないからREADMEにて共有

## 目的
- それぞれの作業を明確にする、チーム全員に作業状況、タスクの共有が目的

## issueの作り方
- 画面上部のタブから「issue」を選択
- 右側に出てくる「new issue」を選択
- titleと概要を入力
- 右側の項目の「assignees」にて担当するプログラマーを選択
- 「submit newissue」をクリック
- 作成完了!!

## 進捗について
- issueを開くとコメントが追加でつけられるので、進捗などをコメントしていこう

## closeについて
- 作業が完了したissueはcloseして完了したタスクとして扱おう
- Close issueをクリックでissuewoCloseできる
- closeするときは完了したことなどを最後にコメントしてcloseするとチームが確認しやすくてよいかも

## レビューについて
- issueで目指した完了条件に沿っているかはチームで確認したほうが良さそう、作成できたものに関してはチームに共有してレビュー（ほんとに機能としてできているか確認）をお願いしよう

## テンプレート
- 以下のテンプレートをつかって作るとissueに統一感が出る＆作りやすいので使おう
~~~
## 概要

## 完了条件 
- [ ] 基本これでチェックボックス形式にしよう
## 備考

~~~
