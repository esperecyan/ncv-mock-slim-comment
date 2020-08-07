NCV スリムコメントもどき
========================
配信者コメント入力欄のみのウィンドウを表示する、[NiconamaCommentViewer] 用プラグインです。

[2020-07-27のコメントの仕様変更]と旧コメントAPIの不具合により、
NiconamaCommentViewerから通常コメントが正常に送信できなくなってしまった (コメントフィルターがオフの配信でもオンの挙動をする) ため、
[スリムコメント/スリムタイパー] の配信者コメント版として作成しました。

[バーチャルキャスト]内で[ニコ生タイピング]を行う配信者の利用を想定。

[NiconamaCommentViewer]: https://www.posite-c.com/application/ncv/ "NiconamaCommentViewer とは？　• ニコニコ生放送のコメント専用ビューアです　• 放送中番組、タイムシフトともに利用可能です"
[2020-07-27のコメントの仕様変更]: https://blog.nicovideo.jp/niconews/136447.html "【7月31日更新】【ニコニコ生放送】「部屋」統合／コメントフィルターの提供について｜ニコニコインフォ"
[スリムコメント/スリムタイパー]: https://qasu.azurewebsites.net/app "『スリムコメント』 コメント送信ウィンドウが使えるようになるプラグインです。 / 『スリムタイパー』 コメント送信ウィンドウが使えるようになるプラグインです。タイピング速度の表示機能付き。"
[バーチャルキャスト]: https://virtualcast.jp/ "次元を超えて、なりたい自分になってコミュニケーション。バーチャルキャストは、そんな願望を叶えるVRライブ・コミュニケーションサービスです。"
[ニコ生タイピング]: https://github.com/jz5/namatyping "ニコニコ生放送（http://live.nicovideo.jp/）で放送中のコメントを利用したタイピングゲームです。"

開発を行う場合のフォルダ階層
----------------------------
- 親フォルダ
	+ ncv-mock-slim-comment
		* ncv-mock-slim-comment.sln
	+ NCV
		* Plugin.dll
		* plugins
			- MockSlimComment.dll ← 出力先

ライセンス
---------
当プラグインのライセンスは [Mozilla Public License Version 2.0] \(MPL-2.0) です。

[Mozilla Public License Version 2.0]: https://www.mozilla.org/MPL/2.0/
