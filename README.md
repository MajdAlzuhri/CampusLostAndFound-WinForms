# 🔍 Campus Lost and Found Management System

A comprehensive **3-Tier Desktop Application** built with **C# Windows Forms** and **Microsoft SQL Server** to streamline the reporting, tracking, inventory management, and ownership claim verification of lost and found items across a university campus.

---

## 📌 Table of Contents
- [Overview](#-overview)
- [System Architecture](#-system-architecture)
- [Key Features](#-key-features)
- [Application Screenshots](#-application-screenshots)
- [Technologies Used](#-technologies-used)
- [Database & Setup Instructions](#-database--setup-instructions)
- [Author](#-author)

---

## 📖 Overview
Managing lost belongings on a busy university campus manually often leads to miscommunication, unverified handovers, and lost records. The **Campus Lost and Found Management System** provides a centralized, role-based platform where students and staff can report lost items or submit ownership claims, while campus administrators verify, transfer, and resolve cases securely.

---

## 🏗️ System Architecture
The project strictly implements a **3-Tier Architecture** to ensure separation of concerns, maintainability, and scalability:

1. **`CampusLostAndFound` (Presentation Layer - UI)**
   - Built using C# Windows Forms.
   - Provides distinct dashboards and navigation flows for **Administrators** and **Standard Users**.
   - Features real-time filtering, input validation, and dynamic status indicators.
2. **`CampusLostAndFound.BLL` (Business Logic Layer)**
   - Enforces domain rules and operational workflows.
   - Manages inventory state transitions (e.g., `Move to Found Items`), claim verification rules, and duplicate claim prevention (`HasActiveClaimForItem`).
3. **`CampusLostAndFound.DAL` (Data Access Layer)**
   - Handles all SQL Server communication using **ADO.NET**.
   - Implements parameterized SQL queries to eliminate SQL injection vulnerabilities.

---

## ✨ Key Features
- **🔐 Role-Based Access Control (RBAC):** Secure authentication separating `Admin` privileges (user management, inventory verification, claim approval/rejection) from `User` capabilities (reporting lost items, browsing found items, submitting claims).
- **📦 Lost-to-Found Inventory Lifecycle:** Admins can seamlessly transition recovered lost item reports directly into the verified Found Items inventory.
- **🛡️ Duplicate Claim Prevention:** Automated business rule checks (`HasActiveClaimForItem`) prevent multiple conflicting active claims on the same item.
- **🔎 Dynamic Search & Filtering:** Fast, injection-safe `DataView.RowFilter` searching across categories, dates, locations, and item descriptions.
- **📊 Administrative Dashboard:** Real-time overview of total lost items, found inventory, pending claims, and registered users.

---

## 🖼️ Application Screenshots

> *Note: Upload your screenshots to the `Images/` folder in the repository and update the filenames below.*

### 1. Login & Authentication
![Login Screen](Images/screenshot_login.png)

### 2. Admin Dashboard
![Admin Dashboard](Images/screenshot_admin_dashboard.png)

### 3. Lost & Found Items Management
![Items Management](Images/screenshot_items_management.png)

### 4. Claims Verification Workflow
![Claims Verification](Images/screenshot_claims.png)

### 5. User Portal & Item Claiming
![User Dashboard](Images/screenshot_user_dashboard.png)

---

## 🛠️ Technologies Used
- **Language:** C#
- **UI Framework:** Windows Forms (.NET Framework)
- **Database:** Microsoft SQL Server 2022
- **Data Access:** ADO.NET
- **IDE & Tools:** Visual Studio 2022, Git & GitHub

---

## ⚙️ Database & Setup Instructions
1. **Clone the Repository:**
   ```bash
   git clone [https://github.com/MajdAlzuhri/CampusLostAndFound-WinForms.git](https://github.com/MajdAlzuhri/CampusLostAndFound-WinForms.git)
