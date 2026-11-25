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
<img width="1185" height="692" alt="image" src="https://github.com/user-attachments/assets/7c587a7a-2d22-4a41-bff6-559ec77f378b" />

### 2. Admin Dashboard
<img width="1577" height="926" alt="image" src="https://github.com/user-attachments/assets/bf7bd7a2-fb03-4ca2-a86f-6e5da7312d12" />
<img width="1575" height="927" alt="image" src="https://github.com/user-attachments/assets/3cf94730-ff36-4625-8702-4c451095ef76" />


### 3. Lost & Found Items Management
<img width="1575" height="930" alt="Lost Management" src="https://github.com/user-attachments/assets/5abc84e2-d8a6-429d-ad35-12caf1bb19e0" />


### 4. Claims Verification Workflow
<img width="1577" height="923" alt="Manage Claims" src="https://github.com/user-attachments/assets/29fa0456-dddd-462c-9e74-b33b27be3ec1" />
<img width="1575" height="925" alt="Claims" src="https://github.com/user-attachments/assets/9e005239-ebef-4312-8356-6a139acde307" />


### 5. User Portal & Item Claiming
<img width="1577" height="935" alt="image" src="https://github.com/user-attachments/assets/c24ada36-2b58-4f48-b7a9-b8d969a5aa30" />

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
