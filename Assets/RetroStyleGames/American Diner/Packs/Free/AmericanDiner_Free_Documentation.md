# American Diner Free – Exterior – Documentation

---

## Overview

A free exterior slice of the American Diner: the closed diner building shell with clear reflective glass windows and doors and a lit interior backdrop behind them, rounded corners, fascia pieces, roof, rooftop DINER sign, exterior neon trim and ventilation units, plus the parking lot kit (asphalt, paving, curbs, stone fences, parking stripes and puddles). The interior, furniture, props and the drivable car are not included; they are part of the American Diner Complete pack.

Ready-to-use prefabs from the American Diner library. Unchanged assets keep the Complete pack's paths and GUIDs; the `_Opaque` window/door prefabs, `M_Glass_Reflective`, the `RSG/Glass_Reflective` shader, the reflection cubemap and the interior card (`P_SM_Interior_Strip`, `M_Interior_Strip`) are new assets.

---

## Render Pipeline Compatibility

- Built-in Render Pipeline (BRP)
- Universal Render Pipeline (URP)
- High Definition Render Pipeline (HDRP)

Product materials use RSG Shader Graphs that support these pipelines: `Assets/RetroStyleGames/American Diner/Base/Shaders/RSG_Puddle.shadergraph`; `Assets/RetroStyleGames/Base/Shaders/RSG_Lit.shadergraph`; `Assets/RetroStyleGames/Base/Shaders/RSG_Lit_Cutout.shadergraph`; `Assets/RetroStyleGames/Base/Shaders/RSG_Lit_Transparent.shadergraph`. The pack contains separate Base, BRP, URP and HDRP material/prefab sets. Use the variant for your active pipeline. Scenes have pipeline-specific lighting and post processing, so their images can differ. Keep the supplied materials; do not run a global material converter.

`M_Sky_Diner` uses Unity's built-in `Skybox/Cubemap` shader. BRP/URP use the skybox; HDRP uses its sky/volume settings.

---

## Requirements

- **Unity 6000.0 LTS (Unity 6)**; the pack is built in Unity **6000.0.77f1**.
- **Shader Graph 17.0.x** in every pipeline, including Built-in.
- **Universal RP 17.0.x** and/or **High Definition RP 17.0.x** for the pipeline you use.
- **Post Processing** (`com.unity.postprocessing`) **3.4.0** for Built-in scene post processing.
- **Linear color space** for the supplied scenes/materials.

---

## Technical Details

- **Prefabs:** 316 total (Base: 79; BRP: 79; URP: 79; HDRP: 79); 79 source assets.
- **Meshes:** 79 FBX files.
- **Vertices:** 271,740 across all prefab files; 67,935 for one source set (4 – 12,739 per asset).
- **Triangles:** 264,536 across all prefab files; 66,134 for one source set (2 – 10,034 per asset).
- **Materials:** 75 total (separate files across the material folders, including the sky material).
- **Textures:** 63 total (shared maps, small defaults and scene sky included).
- **Texture Resolution:** 4 at 4 × 4 px, 1 at 16 × 16 px, 2 at 1024 × 1024 px, 46 at 2048 × 2048 px, 3 at 4096 × 2048 px, 1 at 8192 × 1024 px, 6 at 4096 × 4096 px
- **FBX Import:** 70 Generic, 9 None; animation import disabled on all FBX files.
- **Animations:** No animation clips included.
- **Colliders:** Intentionally absent on 25 decorative source assets and their variants; see Model/Notes.
- **Scripts:** None (assets and scenes only).
- **Scenes:** 6 (Demo + Overview per render pipeline).
- **Units:** 1 Unity unit = 1 metre.

Counts come from the exported Unity scan. Pipeline prefab copies share source geometry; summing their geometry counts repeats the same asset in each set. Generic FBX import settings do not imply a character rig or supplied animation.

---

## Prefab Variants

`Base/Prefabs/P_SM_X.prefab` is the pipeline-neutral source. For scene use, choose `BRP/Prefabs/P_SM_X_BRP.prefab`, `URP/Prefabs/P_SM_X_URP.prefab` or `HDRP/Prefabs/P_SM_X_HDRP.prefab` for your pipeline. The model table links every included version. The prefab total counts all source and variant files, not just unique designs.

---

## Model

Each row groups a Base prefab and its BRP/URP/HDRP variants. The scan confirms identical geometry, material-slot counts, collision and bounds across each group. **Material slots** count renderer slots, not unique materials. **Mesh** = non-convex MeshCollider; **Convex** = convex MeshCollider. Size is renderer bounds (X × Y height × Z) in the supplied orientation, rounded to the scan precision.

| Source asset | Prefab files | Vertices | Triangles | Material slots | Collider | Size (m) |
|---|---|---:|---:|---:|---|---|
| `P_SM_CURB_Corner_FL` | [Base](<../../Base/Prefabs/P_SM_CURB_Corner_FL.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_CURB_Corner_FL_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_CURB_Corner_FL_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_CURB_Corner_FL_HDRP.prefab>) | 132 | 68 | 1 | Mesh | 0.23 × 0.18 × 0.22 |
| `P_SM_CURB_Front_01` | [Base](<../../Base/Prefabs/P_SM_CURB_Front_01.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_CURB_Front_01_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_CURB_Front_01_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_CURB_Front_01_HDRP.prefab>) | 136 | 80 | 1 | Mesh | 1.40 × 0.18 × 0.20 |
| `P_SM_Dinner_Metal` | [Base](<../../Base/Prefabs/P_SM_Dinner_Metal.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Dinner_Metal_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Dinner_Metal_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Dinner_Metal_HDRP.prefab>) | 12,739 | 10,034 | 2 | Mesh | 8.20 × 2.51 × 1.37 |
| `P_SM_Door_Left_Opaque` | [Base](<../../Base/Prefabs/P_SM_Door_Left_Opaque.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Door_Left_Opaque_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Door_Left_Opaque_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Door_Left_Opaque_HDRP.prefab>) | 3,355 | 2,980 | 3 | Mesh | 0.87 × 2.27 × 0.23 |
| `P_SM_Door_Right_Opaque` | [Base](<../../Base/Prefabs/P_SM_Door_Right_Opaque.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Door_Right_Opaque_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Door_Right_Opaque_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Door_Right_Opaque_HDRP.prefab>) | 3,356 | 2,980 | 3 | Mesh | 0.87 × 2.27 × 0.23 |
| `P_SM_E06_Above_MOD_ENTRY_3m` | [Base](<../../Base/Prefabs/P_SM_E06_Above_MOD_ENTRY_3m.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_E06_Above_MOD_ENTRY_3m_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_E06_Above_MOD_ENTRY_3m_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_E06_Above_MOD_ENTRY_3m_HDRP.prefab>) | 324 | 216 | 1 | Mesh | 3.00 × 0.64 × 0.30 |
| `P_SM_E06_Above_Window_Front_04` | [Base](<../../Base/Prefabs/P_SM_E06_Above_Window_Front_04.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_E06_Above_Window_Front_04_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_E06_Above_Window_Front_04_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_E06_Above_Window_Front_04_HDRP.prefab>) | 1,498 | 1,544 | 1 | Mesh | 3.16 × 0.64 × 3.16 |
| `P_SM_Entrance_Opaque` | [Base](<../../Base/Prefabs/P_SM_Entrance_Opaque.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Entrance_Opaque_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Entrance_Opaque_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Entrance_Opaque_HDRP.prefab>) | 652 | 424 | 3 | Mesh | 3.00 × 3.00 × 0.58 |
| `P_SM_Fence` | [Base](<../../Base/Prefabs/P_SM_Fence.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Fence_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Fence_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Fence_HDRP.prefab>) | 105 | 100 | 1 | Mesh | 0.41 × 0.99 × 1.87 |
| `P_SM_Fence_003` | [Base](<../../Base/Prefabs/P_SM_Fence_003.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Fence_003_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Fence_003_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Fence_003_HDRP.prefab>) | 105 | 100 | 1 | Mesh | 0.41 × 0.99 × 1.87 |
| `P_SM_Fence_009` | [Base](<../../Base/Prefabs/P_SM_Fence_009.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Fence_009_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Fence_009_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Fence_009_HDRP.prefab>) | 105 | 100 | 1 | Mesh | 1.87 × 0.99 × 0.41 |
| `P_SM_Fence_014` | [Base](<../../Base/Prefabs/P_SM_Fence_014.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Fence_014_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Fence_014_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Fence_014_HDRP.prefab>) | 105 | 100 | 1 | Mesh | 1.87 × 0.99 × 0.41 |
| `P_SM_Fence_023` | [Base](<../../Base/Prefabs/P_SM_Fence_023.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Fence_023_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Fence_023_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Fence_023_HDRP.prefab>) | 105 | 100 | 1 | Mesh | 0.41 × 0.99 × 1.87 |
| `P_SM_Fence_025` | [Base](<../../Base/Prefabs/P_SM_Fence_025.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Fence_025_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Fence_025_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Fence_025_HDRP.prefab>) | 105 | 100 | 1 | Mesh | 0.41 × 0.99 × 1.87 |
| `P_SM_Fence_032` | [Base](<../../Base/Prefabs/P_SM_Fence_032.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Fence_032_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Fence_032_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Fence_032_HDRP.prefab>) | 105 | 100 | 1 | Mesh | 1.87 × 0.99 × 0.41 |
| `P_SM_Fence_040` | [Base](<../../Base/Prefabs/P_SM_Fence_040.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Fence_040_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Fence_040_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Fence_040_HDRP.prefab>) | 105 | 100 | 1 | Mesh | 1.87 × 0.99 × 0.41 |
| `P_SM_Fence_Round` | [Base](<../../Base/Prefabs/P_SM_Fence_Round.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Fence_Round_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Fence_Round_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Fence_Round_HDRP.prefab>) | 242 | 320 | 1 | Mesh | 1.39 × 0.99 × 1.31 |
| `P_SM_Fence_Round_001` | [Base](<../../Base/Prefabs/P_SM_Fence_Round_001.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Fence_Round_001_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Fence_Round_001_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Fence_Round_001_HDRP.prefab>) | 242 | 320 | 1 | Mesh | 1.31 × 0.99 × 1.39 |
| `P_SM_Fence_Round_002` | [Base](<../../Base/Prefabs/P_SM_Fence_Round_002.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Fence_Round_002_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Fence_Round_002_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Fence_Round_002_HDRP.prefab>) | 242 | 320 | 1 | Mesh | 1.39 × 0.99 × 1.31 |
| `P_SM_Fence_Round_003` | [Base](<../../Base/Prefabs/P_SM_Fence_Round_003.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Fence_Round_003_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Fence_Round_003_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Fence_Round_003_HDRP.prefab>) | 242 | 320 | 1 | Mesh | 1.31 × 0.99 × 1.39 |
| `P_SM_Interior_Strip` | [Base](<../../Base/Prefabs/P_SM_Interior_Strip.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Interior_Strip_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Interior_Strip_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Interior_Strip_HDRP.prefab>) | 1,406 | 1,404 | 1 | None (decorative) | 17.72 × 2.32 × 7.82 |
| `P_SM_PAVING_0_0_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_0_0_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_0_0_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_0_0_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_0_0_Standard_HDRP.prefab>) | 17 | 15 | 1 | Mesh | 1.85 × 0.00 × 1.85 |
| `P_SM_PAVING_0_1_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_0_1_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_0_1_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_0_1_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_0_1_Standard_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 0.71 × 0.00 × 3.00 |
| `P_SM_PAVING_0_2_Crack` | [Base](<../../Base/Prefabs/P_SM_PAVING_0_2_Crack.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_0_2_Crack_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_0_2_Crack_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_0_2_Crack_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 0.71 × 0.00 × 3.00 |
| `P_SM_PAVING_0_3_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_0_3_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_0_3_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_0_3_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_0_3_Standard_HDRP.prefab>) | 17 | 15 | 1 | Mesh | 1.85 × 0.00 × 2.75 |
| `P_SM_PAVING_1_0_Crack` | [Base](<../../Base/Prefabs/P_SM_PAVING_1_0_Crack.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_1_0_Crack_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_1_0_Crack_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_1_0_Crack_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 3.00 × 0.00 × 0.71 |
| `P_SM_PAVING_1_3_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_1_3_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_1_3_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_1_3_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_1_3_Standard_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 3.00 × 0.00 × 0.71 |
| `P_SM_PAVING_2_0_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_2_0_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_2_0_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_2_0_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_2_0_Standard_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 3.00 × 0.00 × 0.71 |
| `P_SM_PAVING_2_3_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_2_3_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_2_3_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_2_3_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_2_3_Standard_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 3.00 × 0.00 × 0.71 |
| `P_SM_PAVING_3_0_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_3_0_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_3_0_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_3_0_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_3_0_Standard_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 3.00 × 0.00 × 0.71 |
| `P_SM_PAVING_3_3_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_3_3_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_3_3_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_3_3_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_3_3_Standard_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 3.00 × 0.00 × 0.71 |
| `P_SM_PAVING_4_0_Crack` | [Base](<../../Base/Prefabs/P_SM_PAVING_4_0_Crack.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_4_0_Crack_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_4_0_Crack_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_4_0_Crack_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 3.00 × 0.00 × 0.71 |
| `P_SM_PAVING_4_3_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_4_3_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_4_3_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_4_3_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_4_3_Standard_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 3.00 × 0.00 × 0.71 |
| `P_SM_PAVING_5_0_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_5_0_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_5_0_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_5_0_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_5_0_Standard_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 3.00 × 0.00 × 0.71 |
| `P_SM_PAVING_5_3_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_5_3_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_5_3_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_5_3_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_5_3_Standard_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 3.00 × 0.00 × 0.71 |
| `P_SM_PAVING_6_0_Pothole` | [Base](<../../Base/Prefabs/P_SM_PAVING_6_0_Pothole.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_6_0_Pothole_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_6_0_Pothole_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_6_0_Pothole_HDRP.prefab>) | 17 | 15 | 1 | Mesh | 2.75 × 0.00 × 1.85 |
| `P_SM_PAVING_6_1_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_6_1_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_6_1_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_6_1_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_6_1_Standard_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 0.71 × 0.00 × 3.00 |
| `P_SM_PAVING_6_2_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_6_2_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_6_2_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_6_2_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_6_2_Standard_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 0.71 × 0.00 × 3.00 |
| `P_SM_PAVING_6_3_Standard` | [Base](<../../Base/Prefabs/P_SM_PAVING_6_3_Standard.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_PAVING_6_3_Standard_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_PAVING_6_3_Standard_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_PAVING_6_3_Standard_HDRP.prefab>) | 17 | 15 | 1 | Mesh | 2.75 × 0.00 × 2.75 |
| `P_SM_Parking_decal` | [Base](<../../Base/Prefabs/P_SM_Parking_decal.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Parking_decal_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Parking_decal_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Parking_decal_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 0.29 × 0.00 × 6.00 |
| `P_SM_Puddle_001` | [Base](<../../Base/Prefabs/P_SM_Puddle_001.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_001_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_001_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_001_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 3.08 × 0.00 × 3.08 |
| `P_SM_Puddle_002` | [Base](<../../Base/Prefabs/P_SM_Puddle_002.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_002_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_002_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_002_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 3.08 × 0.00 × 3.08 |
| `P_SM_Puddle_003` | [Base](<../../Base/Prefabs/P_SM_Puddle_003.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_003_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_003_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_003_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 2.45 × 0.00 × 2.45 |
| `P_SM_Puddle_004` | [Base](<../../Base/Prefabs/P_SM_Puddle_004.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_004_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_004_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_004_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 3.08 × 0.00 × 3.08 |
| `P_SM_Puddle_005` | [Base](<../../Base/Prefabs/P_SM_Puddle_005.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_005_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_005_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_005_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 3.08 × 0.00 × 3.08 |
| `P_SM_Puddle_006` | [Base](<../../Base/Prefabs/P_SM_Puddle_006.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_006_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_006_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_006_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 2.83 × 0.00 × 2.83 |
| `P_SM_Puddle_008` | [Base](<../../Base/Prefabs/P_SM_Puddle_008.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_008_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_008_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_008_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 4.36 × 0.00 × 4.36 |
| `P_SM_Puddle_009` | [Base](<../../Base/Prefabs/P_SM_Puddle_009.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_009_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_009_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_009_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 4.14 × 0.00 × 4.14 |
| `P_SM_Puddle_010` | [Base](<../../Base/Prefabs/P_SM_Puddle_010.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_010_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_010_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_010_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 2.51 × 0.00 × 2.51 |
| `P_SM_Puddle_011` | [Base](<../../Base/Prefabs/P_SM_Puddle_011.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_011_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_011_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_011_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 2.60 × 0.00 × 2.60 |
| `P_SM_Puddle_013` | [Base](<../../Base/Prefabs/P_SM_Puddle_013.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_013_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_013_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_013_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 2.66 × 0.00 × 2.66 |
| `P_SM_Puddle_015` | [Base](<../../Base/Prefabs/P_SM_Puddle_015.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_015_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_015_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_015_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 4.22 × 0.00 × 4.22 |
| `P_SM_Puddle_016` | [Base](<../../Base/Prefabs/P_SM_Puddle_016.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_016_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_016_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_016_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 3.18 × 0.00 × 3.18 |
| `P_SM_Puddle_018` | [Base](<../../Base/Prefabs/P_SM_Puddle_018.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Puddle_018_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Puddle_018_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Puddle_018_HDRP.prefab>) | 4 | 2 | 1 | None (decorative) | 2.65 × 0.00 × 2.65 |
| `P_SM_Roof_3x3` | [Base](<../../Base/Prefabs/P_SM_Roof_3x3.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Roof_3x3_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Roof_3x3_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Roof_3x3_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 3.00 × 0.00 × 3.00 |
| `P_SM_Rounded_FR_Corner_Opaque` | [Base](<../../Base/Prefabs/P_SM_Rounded_FR_Corner_Opaque.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Rounded_FR_Corner_Opaque_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Rounded_FR_Corner_Opaque_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Rounded_FR_Corner_Opaque_HDRP.prefab>) | 7,337 | 3,934 | 5 | Mesh | 3.15 × 3.00 × 3.15 |
| `P_SM_Rounded_RL_Corner` | [Base](<../../Base/Prefabs/P_SM_Rounded_RL_Corner.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Rounded_RL_Corner_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Rounded_RL_Corner_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Rounded_RL_Corner_HDRP.prefab>) | 698 | 576 | 2 | Mesh | 3.15 × 3.00 × 3.15 |
| `P_SM_Rounded_RR_Corner_Opaque` | [Base](<../../Base/Prefabs/P_SM_Rounded_RR_Corner_Opaque.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Rounded_RR_Corner_Opaque_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Rounded_RR_Corner_Opaque_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Rounded_RR_Corner_Opaque_HDRP.prefab>) | 3,180 | 1,798 | 5 | Mesh | 3.15 × 3.00 × 3.15 |
| `P_SM_Rounded_Window_Corner_Opaque` | [Base](<../../Base/Prefabs/P_SM_Rounded_Window_Corner_Opaque.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Rounded_Window_Corner_Opaque_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Rounded_Window_Corner_Opaque_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Rounded_Window_Corner_Opaque_HDRP.prefab>) | 9,792 | 5,168 | 3 | Mesh | 3.15 × 3.00 × 3.15 |
| `P_SM_Wall_Inner_01` | [Base](<../../Base/Prefabs/P_SM_Wall_Inner_01.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Wall_Inner_01_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Wall_Inner_01_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Wall_Inner_01_HDRP.prefab>) | 120 | 68 | 2 | Mesh | 0.25 × 3.00 × 3.00 |
| `P_SM_Wall_Inner_01_001` | [Base](<../../Base/Prefabs/P_SM_Wall_Inner_01_001.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Wall_Inner_01_001_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Wall_Inner_01_001_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Wall_Inner_01_001_HDRP.prefab>) | 120 | 68 | 2 | Mesh | 3.00 × 3.00 × 0.25 |
| `P_SM_Wall_Inner_01_002` | [Base](<../../Base/Prefabs/P_SM_Wall_Inner_01_002.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Wall_Inner_01_002_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Wall_Inner_01_002_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Wall_Inner_01_002_HDRP.prefab>) | 120 | 68 | 2 | Mesh | 3.00 × 3.00 × 0.25 |
| `P_SM_Wall_Inner_01_005` | [Base](<../../Base/Prefabs/P_SM_Wall_Inner_01_005.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Wall_Inner_01_005_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Wall_Inner_01_005_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Wall_Inner_01_005_HDRP.prefab>) | 118 | 60 | 2 | Mesh | 0.25 × 3.00 × 3.00 |
| `P_SM_Wall_Inner_01_006` | [Base](<../../Base/Prefabs/P_SM_Wall_Inner_01_006.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Wall_Inner_01_006_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Wall_Inner_01_006_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Wall_Inner_01_006_HDRP.prefab>) | 118 | 60 | 2 | Mesh | 0.25 × 3.00 × 2.91 |
| `P_SM_Wall_Inner_01_007` | [Base](<../../Base/Prefabs/P_SM_Wall_Inner_01_007.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Wall_Inner_01_007_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Wall_Inner_01_007_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Wall_Inner_01_007_HDRP.prefab>) | 118 | 60 | 2 | Mesh | 2.82 × 3.00 × 0.25 |
| `P_SM_Window_Front_01_Opaque` | [Base](<../../Base/Prefabs/P_SM_Window_Front_01_Opaque.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Window_Front_01_Opaque_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Window_Front_01_Opaque_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Window_Front_01_Opaque_HDRP.prefab>) | 1,452 | 2,536 | 3 | Mesh | 0.25 × 3.00 × 3.00 |
| `P_SM_Window_Front_02_Opaque` | [Base](<../../Base/Prefabs/P_SM_Window_Front_02_Opaque.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Window_Front_02_Opaque_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Window_Front_02_Opaque_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Window_Front_02_Opaque_HDRP.prefab>) | 1,452 | 2,536 | 3 | Mesh | 3.00 × 3.00 × 0.25 |
| `P_SM_Window_Front_03_Opaque` | [Base](<../../Base/Prefabs/P_SM_Window_Front_03_Opaque.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_Window_Front_03_Opaque_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_Window_Front_03_Opaque_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_Window_Front_03_Opaque_HDRP.prefab>) | 1,452 | 2,536 | 3 | Mesh | 3.00 × 3.00 × 0.25 |
| `P_SM_asphalt` | [Base](<../../Base/Prefabs/P_SM_asphalt.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_asphalt_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_asphalt_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_asphalt_HDRP.prefab>) | 4 | 2 | 1 | Mesh | 9.00 × 0.00 × 9.00 |
| `P_SM_neon_rounded_1` | [Base](<../../Base/Prefabs/P_SM_neon_rounded_1.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_neon_rounded_1_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_neon_rounded_1_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_neon_rounded_1_HDRP.prefab>) | 2,784 | 4,462 | 1 | None (decorative) | 3.22 × 0.26 × 3.22 |
| `P_SM_neon_rounded_1_001` | [Base](<../../Base/Prefabs/P_SM_neon_rounded_1_001.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_neon_rounded_1_001_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_neon_rounded_1_001_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_neon_rounded_1_001_HDRP.prefab>) | 2,784 | 4,462 | 1 | None (decorative) | 3.22 × 0.26 × 3.22 |
| `P_SM_neon_rounded_1_002` | [Base](<../../Base/Prefabs/P_SM_neon_rounded_1_002.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_neon_rounded_1_002_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_neon_rounded_1_002_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_neon_rounded_1_002_HDRP.prefab>) | 2,784 | 4,462 | 1 | None (decorative) | 3.22 × 0.26 × 3.22 |
| `P_SM_neon_rounded_1_003` | [Base](<../../Base/Prefabs/P_SM_neon_rounded_1_003.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_neon_rounded_1_003_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_neon_rounded_1_003_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_neon_rounded_1_003_HDRP.prefab>) | 2,784 | 4,462 | 1 | None (decorative) | 3.22 × 0.26 × 3.22 |
| `P_SM_neon_straight_1` | [Base](<../../Base/Prefabs/P_SM_neon_straight_1.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_neon_straight_1_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_neon_straight_1_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_neon_straight_1_HDRP.prefab>) | 788 | 1,258 | 1 | None (decorative) | 3.02 × 0.26 × 0.07 |
| `P_SM_neon_straight_1_004` | [Base](<../../Base/Prefabs/P_SM_neon_straight_1_004.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_neon_straight_1_004_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_neon_straight_1_004_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_neon_straight_1_004_HDRP.prefab>) | 788 | 1,258 | 1 | None (decorative) | 0.07 × 0.26 × 3.02 |
| `P_SM_neon_straight_1_005` | [Base](<../../Base/Prefabs/P_SM_neon_straight_1_005.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_neon_straight_1_005_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_neon_straight_1_005_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_neon_straight_1_005_HDRP.prefab>) | 788 | 1,258 | 1 | None (decorative) | 3.02 × 0.26 × 0.07 |
| `P_SM_neon_straight_1_009` | [Base](<../../Base/Prefabs/P_SM_neon_straight_1_009.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_neon_straight_1_009_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_neon_straight_1_009_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_neon_straight_1_009_HDRP.prefab>) | 788 | 1,258 | 1 | None (decorative) | 0.07 × 0.26 × 3.02 |
| `P_SM_neon_straight_1_019` | [Base](<../../Base/Prefabs/P_SM_neon_straight_1_019.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_neon_straight_1_019_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_neon_straight_1_019_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_neon_straight_1_019_HDRP.prefab>) | 788 | 1,258 | 1 | None (decorative) | 3.02 × 0.26 × 0.07 |
| `P_SM_ventilation_unit` | [Base](<../../Base/Prefabs/P_SM_ventilation_unit.prefab>) / [BRP](<../../BRP/Prefabs/P_SM_ventilation_unit_BRP.prefab>) / [URP](<../../URP/Prefabs/P_SM_ventilation_unit_URP.prefab>) / [HDRP](<../../HDRP/Prefabs/P_SM_ventilation_unit_HDRP.prefab>) | 1,184 | 596 | 1 | Convex | 1.79 × 1.03 × 1.28 |
| **Total (79 source assets)** | | **67,935** | **66,134** | | | |
| **Total (316 prefab files)** | | **271,740** | **264,536** | | | |

---

## Textures

- **63 texture files**; imported resolutions are listed above.
- **BC**: Base Color, sRGB. Alpha is used by cutout/transparent materials where applicable.
- **N**: imported as Normal Map, with sRGB disabled.
- **MAS**: linear packed material data, R = metallic, G = ambient occlusion, A = smoothness (1 minus roughness). B is unused unless a material specifies an extra channel.
- **E**: sRGB emission maps, used by `M_Interior_Strip`, `M_OPEN_BakedPBR_v001`, `M_Warm_Neon`, `M_neon`, `M_neon_inner`.
- **HDR cubemaps** (scene sky `T_Sky_Diner`, glass reflection `T_Glass_Reflection_Cube`): `T_Glass_Reflection_Cube.exr`, `T_Sky_Diner.exr` imported as HDR cubemap data (sRGB disabled).
- **Small default maps:** 4 at 4 × 4 px, 1 at 16 × 16 px; intentional constant/default maps included in the texture total.

---

## Features

- Modular grid: 3 × 3 m wall, roof and paving modules.
- Clear shop-window glass (`M_Glass_Reflective`, shader `RSG/Glass_Reflective`): the interior stays visible while a sharp reflection from the pack's own baked cubemap (`T_Glass_Reflection_Cube`) is added on top with a Fresnel falloff. One shader works in BRP, URP and HDRP.
- Interior backdrop `P_SM_Interior_Strip`: one emissive card that follows the glazing 0.14-0.23 m inside the glass (left return, rounded corners, frontage, right side) with a painted diner interior (`T_M_Interior_Strip_E`, 8192 px wide), so the closed shell reads as a lit diner from outside.
- Rounded facade corners, glazed frontage, side and rear walls, fascia trims, roof modules, rooftop DINER sign and ventilation units.
- Exterior neon trim sections with emissive materials.
- Parking lot kit: asphalt, standard/cracked/pothole paving, curbs, straight and rounded stone fences, parking stripes and puddles.
- Exterior Demo and asset Overview scenes for each pipeline.

---

## Included Content

Paths below are relative to `Assets/RetroStyleGames/`. Only the free pack's content and its dependencies are included.

- 316 prefab files (79 source assets): 79 in `American Diner/BRP/Prefabs`; 79 in `American Diner/Base/Prefabs`; 79 in `American Diner/HDRP/Prefabs`; 79 in `American Diner/URP/Prefabs`.
- 79 FBX files: 79 in `American Diner/Base/Models`.
- 75 material files: 22 in `American Diner/BRP/Materials`; 9 in `American Diner/Base/Materials`; 22 in `American Diner/HDRP/Materials`; 22 in `American Diner/URP/Materials`.
- 63 texture files: 63 in `American Diner/Base/Textures`.
- 4 Shader Graphs: `American Diner/Base/Shaders/RSG_Puddle.shadergraph`, `Base/Shaders/RSG_Lit.shadergraph`, `Base/Shaders/RSG_Lit_Cutout.shadergraph`, `Base/Shaders/RSG_Lit_Transparent.shadergraph`.
- 1 hand-written shader for BRP / URP / HDRP: `American Diner/Base/Shaders/RSG_Glass_Reflective.shader` (`RSG/Glass_Reflective`, used by `M_Glass_Reflective`).
- 6 scenes in `American Diner/Packs/Free/Scenes/<RP>/` (listed below).
- URP pipeline and renderer: `American Diner/URP/Settings/URP.asset`, `Renderer.asset`; volume profiles in the same settings folder.
- HDRP pipeline: `American Diner/HDRP/Settings/HDRP.asset`; global/default resources in `HDRP/Settings/Defaults`, plus scene volume and ambient/sky profiles in `HDRP/Settings`.
- BRP post-process profile: `American Diner/BRP/Settings/Approved_Post.asset`.
- No runtime scripts or controllers are included in this free pack.
- This documentation: `American Diner/Packs/Free/AmericanDiner_Free_Documentation.md`.

---

## Demo Scenes

Scenes are relative to `Assets/RetroStyleGames/American Diner/Packs/Free/`:

| Pipeline | Overview scene | Demo scene |
|---|---|---|
| BRP | `Scenes/BRP/AmericanDiner_Free_Overview_BRP.unity` | `Scenes/BRP/AmericanDiner_Free_Demo_BRP.unity` |
| URP | `Scenes/URP/AmericanDiner_Free_Overview_URP.unity` | `Scenes/URP/AmericanDiner_Free_Demo_URP.unity` |
| HDRP | `Scenes/HDRP/AmericanDiner_Free_Overview_HDRP.unity` | `Scenes/HDRP/AmericanDiner_Free_Demo_HDRP.unity` |

**Overview:** the source assets displayed using the matching pipeline variants.

**Demo:** the closed diner building on its parking lot at dusk, with exterior neon, sky and post processing. Each pipeline supplies its own static cameras and lighting. No walkthrough controller or animated neon flicker is included.

---

## Setup Instructions

0. **Built-in:** install **Shader Graph 17.0.x** in Package Manager, plus **Post Processing 3.4.0** for the supplied scene effects.
1. Install the pipeline package you use before importing the pack. URP/HDRP include Shader Graph. Wait for package resolution and compilation.
2. Import the unitypackage with its shared shaders and dependencies. Set **Project Settings > Player > Other Settings > Color Space** to **Linear**.
3. In **Project Settings > Graphics**, set **Default Render Pipeline** to `Assets/RetroStyleGames/American Diner/URP/Settings/URP.asset` for URP, `Assets/RetroStyleGames/American Diner/HDRP/Settings/HDRP.asset` for HDRP, or **None** for Built-in.
4. In **Project Settings > Quality**, check every quality level you intend to use. Assign its **Render Pipeline Asset** to the matching asset, or clear the override to inherit Graphics. For Built-in use **None**. Conflicting quality overrides can select the wrong pipeline.
5. Open the scene for your pipeline from the table above. The pack uses manual setup; no pipeline-switch menu is included. Open only scenes whose pipeline packages are installed.
6. Use prefabs from `American Diner/<RP>/Prefabs` for your pipeline. `Base/Prefabs` contains the pipeline-neutral sources.

Keep the included URP renderer and scene volume profiles. For HDRP, retain `HDRP/Settings/Defaults/HDRenderPipelineGlobalSettings.asset` and the ambient/sky profiles. If URP/HDRP was installed after importing the pack, right-click `Assets/RetroStyleGames/Base/Shaders` and choose **Reimport**. Also reimport `Assets/RetroStyleGames/American Diner/Base/Shaders` for the included puddle graph. Do not use a global material converter on the supplied materials.

---

## Viewing the Demo

Open the scene for your pipeline and use the Scene view to explore it. The included cameras provide static views. The free pack contains assets and scenes only: no walking controls or animated neon controller.

---

## Pipeline Dependencies and Validator Warnings

The unitypackage includes all three pipeline variants. In a project with only URP installed, Asset Store Tools scans the BRP and HDRP scenes too. Missing components in those unused scenes are expected package dependencies, not broken URP objects:

- BRP Demo: `View_CAM_Exterior_Main` and `Main Camera` use `PostProcessLayer`; `Approved BRP Post` uses `PostProcessVolume`. BRP Overview: `Overview Camera` uses `PostProcessLayer`; `Approved BRP Post(Clone)` uses `PostProcessVolume`. Install Post Processing 3.4.0 to use the authored BRP post processing.
- HDRP Demo: four lights use `HDAdditionalLightData`, two cameras use `HDAdditionalCameraData`, two reflection probes use `HDAdditionalReflectionData`, and `URP Ambient Equivalent` uses `StaticLightingSky`. HDRP Overview: `Overview Camera` and `Overview Sun` use the corresponding HDRP camera/light components. Install the matching HDRP package before using these scenes.
- Keep these serialized components. They contain authored settings for the demo look. Recreating a missing component with defaults does not restore those settings. Do not remove missing scripts from the other pipeline scenes or save them after stripping components.
- For a URP-only import, include the shared `Base` content, `URP` content, and `Packs/Free/Scenes/URP`; omit the `BRP`, `HDRP`, `Scenes/BRP`, and `Scenes/HDRP` folders. The original all-pipeline import intentionally retains these optional dependencies. A separately distributed per-pipeline package would avoid the cross-pipeline warnings but is not supplied here.

`M_Sky_Diner` intentionally keeps Unity's `Skybox/Cubemap`. The Asset Store Tools SRP test checks for a `UniversalPipeline` or `HDRenderPipeline` subshader tag; this built-in skybox has neither. Unity 6000.3.22f1's built-in Cubemap, 6 Sided, Procedural and Panoramic skyboxes all fail that tag test. This is an accepted skybox warning, not a failure to render the BRP/URP sky. HDRP uses its own sky/volume profiles.

`RSG/Glass_Reflective` now declares separate URP, HDRP and Built-in subshaders sharing the same glass calculation and blend mode. Its material constants are grouped in `UnityPerMaterial`. This keeps the interior card visible and adds the supplied cubemap reflection with the original Fresnel settings. No global material conversion is needed.

---

## Notes

- The building is an exterior shell: there is no real interior geometry (no floor, ceiling or props) and the doors stay closed. The interior seen through the glass is the flat emissive card `P_SM_Interior_Strip`; it is built for this facade layout (place it at the building origin, as in the Demo scenes) and is meant to be seen from outside.
- Glass settings (per material): Interior Visibility, Reflection Facing Camera, Reflection Strength, Grazing Falloff, Grazing Hides Interior, Smoothness, Cubemap Rotation. Swap `Reflection Cubemap` for your own baked probe cubemap to reflect your scene. Interior brightness is the Emission Tint of `M_Interior_Strip`.
- The `_Opaque` window and door prefabs (name kept from the first free release) are this pack's own copies with their own GUIDs; they carry `M_Glass_Reflective`, so importing this pack next to the American Diner Complete does not change the Complete's windows.
- Neon tubes, puddles, the parking decal and the interior card (inside the closed shell) intentionally have no colliders; use the underlying ground for collision.
- All three pipelines use static demo cameras and lighting; runtime controllers are not supplied.
- Keep the supplied child transforms when placing or rotating a prefab root; they preserve its authored mesh orientation and scale.
- Non-convex MeshColliders are intended for static geometry. For movable physics props, use suitable convex/compound collision and add a Rigidbody.
- The sky material uses `Skybox/Cubemap`, so a pipeline-compatibility check may flag this built-in skybox shader. Product materials use the supplied RSG graphs.

AI-generated content: Yes

---

## Support

For questions or assistance, contact support through the Unity Asset Store page.

---

## License

This asset is provided under the standard Unity Asset Store license agreement.
