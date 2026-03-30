# Hair Physics Engine

**Verlet積分 + PBDベースの独自髪物理エンジン / Custom hair physics engine built with Verlet integration & Position Based Dynamics**

VTuberアバターの髪の動きに「質量感と空気抵抗」を与える、リアルタイム髪物理シミュレーションエンジン。
A real-time hair physics simulation engine that brings mass and air resistance to VTuber avatar hair.

## Why / なぜ作るのか

没入してる世界で髪が服を貫通する——その一瞬で世界観が壊れる。Spring Boneでは表現できない「物理的に正しく、かつ美しい動き」を、Verlet積分とPBDで実現する。

When hair clips through clothing in an immersive world, the illusion breaks instantly. Spring Bone alone can't deliver physically correct yet beautiful motion — this engine uses Verlet integration and PBD to achieve both.

## Tech Stack / 技術スタック

| Technology | Role |
|---|---|
| **Unity 6** (C#) | Runtime environment |
| **Verlet Integration** (Störmer method) | Position-based physics simulation |
| **Position Based Dynamics (PBD)** | Constraint solver with relaxation |
| **VRM** | Avatar format support |

## Design Decisions / 設計判断

### Why Verlet + PBD over Spring Bone?
Spring Bone uses a simple spring-damper model — it lacks inertia and accurate gravitational response. Verlet integration operates on positions directly (not velocities), making it inherently stable for real-time simulation. PBD's iterative constraint relaxation allows flexible trade-off between accuracy and performance.

### Why build from scratch instead of using NVIDIA Newton?
Newton (VBD solver) targets high-end GPUs and general-purpose physics. This project focuses on **hair-specific optimization for mid-range hardware** while deeply understanding the underlying physics — a TA's core competency is knowing the "why" behind the tools.

### Why VRM format?
VRM is the de facto standard for VTuber avatars. Building on VRM ensures direct applicability to the VTuber/3D avatar industry.

## Roadmap

| Phase | Description | Status |
|---|---|---|
| Phase 1 | Unity basics (Transform, Quaternion, Prefab) | ✅ |
| Phase 2 | VRM import & hair bone analysis | ✅ |
| Phase 3 | Face/body tracking (MediaPipe + OSC) | ⬜ |
| Phase 4 | Verlet/PBD hair physics implementation | ⬜ |
| Phase 5 | Integration & portfolio demo | ⬜ |

## License

MIT

## Author

**Kosei Hayashi** — Kyoto University, Mechanical Engineering
Aspiring Technical Artist for VTuber/3D avatar industry
