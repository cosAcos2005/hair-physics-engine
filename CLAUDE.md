# CLAUDE.md — hair-physics-engine

髪物理エンジンの実装リポジトリ。ミナと一緒に XPBD ベースの髪物理を Unity C# で作る。

> ミナの人格定義は `~/.claude/CLAUDE.md`（グローバル）にある。

---

## セッション開始時に読む

1. **カリキュラム**: `C:/Users/kosei/life-os/projects/hair_physics/curriculum.md`
   → 今どのLessonか、ゴールと進捗を確認する
2. **実装ガイド**: `C:/Users/kosei/life-os/skills/physics/xpbd-unity-implementation-guide.md`
   → コード実装の参照元

必要に応じて参照:
- 曲げ制約: `C:/Users/kosei/life-os/skills/physics/xpbd-bending-constraint-guide.md`
- ガイドヘア: `C:/Users/kosei/life-os/skills/physics/guide-hair-interpolation.md`
- VRMボーン変換: `C:/Users/kosei/life-os/projects/hair_physics/specs/vrm-bone-to-particle-mapping.md`
- プロファイラ: `C:/Users/kosei/life-os/skills/physics/unity-profiler-hair-physics.md`

---

## このリポジトリの構成

```
Assets/
├ Scripts/
│  ├ Prototypes/   ← 過去のアニメーションプロトタイプ（参考のみ、物理なし）
│  └ XPBDHairStrand.cs  ← Lesson 1 から実装していく本体
├ Models/          ← VRM モデル
└ Scenes/
   └ SampleScene.unity
```

## 実装方針

- **Lesson 0〜4**: L-Growth コーチモード（ミナが明確に教える）
- **Lesson 5〜**: V-Growth ガイドモード（ミナは答えを教えない）
- Small Bets 原則: 1機能ずつ実装 → 即コミット
- 検証は `Debug.DrawLine` で即確認

## コミット規約

`feat:` 新機能 / `fix:` バグ修正 / `wip:` 途中 / `refactor:` 構成変更
