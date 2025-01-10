USE [master]
GO

/****** Object:  Database [Parcial1_GestionProyectos]    Script Date: 10/01/2025 18:21:57 ******/
CREATE DATABASE [Parcial1_GestionProyectos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Parcial1_GestionProyectos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ALWAYSDEV\MSSQL\DATA\Parcial1_GestionProyectos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Parcial1_GestionProyectos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ALWAYSDEV\MSSQL\DATA\Parcial1_GestionProyectos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Parcial1_GestionProyectos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET ARITHABORT OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET RECOVERY FULL 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET  MULTI_USER 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Parcial1_GestionProyectos] SET  READ_WRITE 
GO
