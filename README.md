[![Build (Windows)](https://github.com/SAM-BIM/SAM_AssemblyResolver/actions/workflows/build.yml/badge.svg?branch=master)](https://github.com/SAM-BIM/SAM_AssemblyResolver/actions/workflows/build.yml)
[![Installer (latest)](https://img.shields.io/github/v/release/SAM-BIM/SAM_Deploy?label=installer)](https://github.com/SAM-BIM/SAM_Deploy/releases/latest)

# SAM_AssemblyResolver

<a href="https://github.com/SAM-BIM/SAM">
  <img src="https://github.com/SAM-BIM/SAM/blob/master/Grasshopper/SAM.Core.Grasshopper/Resources/SAM_Small.png"
       align="left" hspace="10" vspace="6">
</a>

**SAM_AssemblyResolver** is part of the **SAM (Sustainable Analytical Model) Toolkit** —  
an open-source collection of tools designed to help engineers create, manage,
and process analytical building models for energy and environmental analysis.

This repository provides **assembly resolution utilities**
intended to simplify dependency management across different host environments,
such as **multiple Rhino and Revit versions**.

The goal is to enable SAM modules to **resolve compatible assemblies at runtime**
without requiring duplicate binaries or repeated builds for each host version.

⚠ **Work in progress** — this module is under active development and its API
and behaviour may change.

---

## Purpose

`SAM_AssemblyResolver` is designed to:
- centralise assembly resolution logic
- reduce duplication of binaries across host versions
- improve maintainability of SAM integrations for Rhino, Revit, and related platforms
- support flexible loading of compatible dependencies at runtime

This repository focuses on infrastructure-level concerns and is not user-facing.

---

## Status

🚧 **Work in progress**

- APIs and implementation details are subject to change

---

## Resources
- 📘 **SAM Wiki:** https://github.com/SAM-BIM/SAM/wiki  
- 🧠 **SAM Core:** https://github.com/SAM-BIM/SAM  

---

## Development notes

- Target framework: **.NET / C#**
- Assembly resolution follows SAM-BIM infrastructure conventions
- Designed to support multiple host application versions
- New or modified `.cs` files must include the SPDX header from `COPYRIGHT_HEADER.txt`

---

## Licence

This repository is free software licensed under the  
**GNU Lesser General Public License v3.0 or later (LGPL-3.0-or-later)**.

Each contributor retains copyright to their respective contributions.  
The project history (Git) records authorship and provenance of all changes.

See:
- `LICENSE`
- `NOTICE`
- `COPYRIGHT_HEADER.txt`
