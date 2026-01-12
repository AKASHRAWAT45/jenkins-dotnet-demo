pipeline {
    agent any

    stages {

        stage('Clone Code') {
            steps {
                // GitHub se code download
                git 'https://github.com/AKASHRAWAT45/CalculatorApp.git'
            }
        }

        stage('Restore Packages') {
            steps {
                // NuGet dependencies download
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                // Project build
                bat 'dotnet build --configuration Release'
            }
        }

        stage('Run Tests') {
            steps {
                // Unit tests run honge
                bat 'dotnet test'
            }
        }
    }

    post {
        success {
            echo 'Build and Tests Passed ✅'
        }
        failure {
            echo 'Build or Tests Failed ❌'
        }
    }
}
