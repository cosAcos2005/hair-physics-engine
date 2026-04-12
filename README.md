# Hair Physics Engine

![Status](https://img.shields.io/badge/status-in%20development-orange)
![Unity](https://img.shields.io/badge/Unity-6-black?logo=unity)
![License](https://img.shields.io/badge/license-MIT-blue)
![Platform](https://img.shields.io/badge/platform-Windows%20%7C%20Mac-lightgrey)

**Verlet積分 + PBDベースの独自髪物理エンジン / Custom hair physics engine built with Verlet integration & Position Based Dynamics**

VTuberアバターの髪の動きに「質量感と空気抵抗」を与える、リアルタイム髪物理シミュレーションエンジン。  
A real-time hair physics simulation engine that brings mass and air resistance to VTuber avatar hair.

---

## Why / なぜ作るのか

没入してる世界で髪が服を貫通する——その一瞬で世界観が壊れる。Spring Boneでは表現できない「物理的に正しく、かつ美しい動き」を、Verlet積分とPBDで実現する。

When hair clips through clothing in an immersive world, the illusion breaks instantly. Spring Bone alone can't deliver physically correct yet beautiful motion — this engine uses Verlet integration and PBD to achieve both.

---

## Tech Stack / 技術スタック

| Technology | Role |
|---|---|
| **Unity 6** (C#) | Runtime environment |
| **Verlet Integration** (Störmer method) | Position-based physics simulation |
| **Position Based Dynamics (PBD)** | Constraint solver with relaxation |
| **UniVRM 0.131.0** | VRM avatar loading & bone access |
| **MediaPipe** *(Phase 3)* | Face / body tracking via OSC |

---

## Roadmap

| Phase | Description | Status |
|---|---|---|
| **Phase 1** | Unity fundamentals (Transform, Quaternion, Prefab, pendulum chain) | ✅ Done |
| **Phase 2** | VRM import, hair bone analysis, BlendShape control | ✅ Done |
| **Phase 3** | Face / body tracking — MediaPipe + OSC / WebSocket | 🔨 In Progress |
| **Phase 4** | Verlet/PBD hair physics core implementation | ⬜ Planned |
| **Phase 5** | Integration, performance profiling & portfolio demo | ⬜ Planned |

---

## Implementation Progress / 実装進捗

### Phase 1 — Unity Fundamentals ✅

- Transform / Quaternion / `localRotation` control
- Parent-child rotation propagation
- 3-segment pendulum chain simulation (Slerp-based)
- Dynamic Prefab instantiation & deletion
- Coordinate system mastery (World / Local / Screen)

### Phase 2 — VRM Integration ✅

- UniVRM v0.131.0 — local package setup (UniVRM + UniGLTF)
- VRM model loading & Hierarchy inspection at runtime
- Hair bone structure analysis (`J_Sec_Hair*` — 3–4 segment chains)
- `localRotation` drive for individual bones
- BlendShape enumeration & script-based facial control (`FaceController.cs`)

### Phase 3 — Face / Body Tracking 🔨

- MediaPipe landmark streaming over OSC / WebSocket
- Real-time bone pose update from tracking data

### Phase 4 — Verlet / PBD Core ⬜

- Störmer–Verlet position integration
- Distance constraints (stretch)
- Bend / twist constraints (PBD relaxation)
- Collision response (capsule per strand)
- Reference: [MGPBD — Li et al., SIGGRAPH 2025](#references) for convergence optimization

---

## Design Decisions / 設計判断

### Why Verlet + PBD over Spring Bone?
Spring Bone uses a simple spring-damper model — it lacks inertia and accurate gravitational response. Verlet integration operates on positions directly (not velocities), making it inherently stable for real-time simulation. PBD's iterative constraint relaxation allows flexible trade-off between accuracy and performance.

### Why build from scratch instead of using NVIDIA Newton?
Newton (VBD solver) targets high-end GPUs and general-purpose physics. This project focuses on **hair-specific optimization for mid-range hardware** (RTX 5060 Ti / 32 GB RAM) while deeply understanding the underlying physics — a TA's core competency is knowing the *why* behind the tools.

### Why VRM format?
VRM is the de facto standard for VTuber avatars. Building on VRM ensures direct applicability to the VTuber / 3D avatar industry pipeline.

---

## References / 参考文献

| Paper | Key Insight Applied |
|---|---|
| Jakobsen, T. — *Advanced Character Physics* (GDC 2001) | Verlet integration basics, constraint relaxation, collision projection |
| Li et al. — *MGPBD* (SIGGRAPH 2025) | Multi-grid acceleration for XPBD; convergence fix for high strand-count |
| Müller et al. — *Position Based Dynamics* (2007) | Core PBD constraint solver formulation |

---

## Repository Structure / ファイル構成

```
Assets/
├── Scripts/
│   ├── FaceController.cs          # BlendShape enumeration & control
│   └── Prototypes/
│       ├── PendulumTest.cs        # Pendulum chain (Phase 1)
│       ├── ChainController.cs     # Mouse-follow chain head
│       ├── ChainSpawner.cs        # Dynamic prefab instantiation
│       ├── CubePhysicsMover.cs    # Physics mover reference
│       └── CubeRotator.cs        # Basic rotation reference
Packages/                          # UniVRM 0.131.0 (local)
```

---

## License

MIT

---

## Author

**Kosei Hayashi** — Kyoto University, Mechanical Engineering (3rd year)  
Aspiring Technical Artist for VTuber / 3D avatar industry  
GitHub: [@cosAcos2005](https://github.com/cosAcos2005)
