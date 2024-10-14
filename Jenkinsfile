pipeline {
    agent any // Chạy trên bất kỳ agent nào

    stages {
        stage('Checkout') {
            steps {
                // Lấy mã nguồn từ repository
                git branch: 'main', url: 'https://github.com/maivudhsp/testjenkins', credentialsId: 'your-credential-id'
            }
        }
        stage('Build') {
            steps {
                // Thực hiện các bước build dự án
                echo 'Building the application...'
                // Thêm lệnh build cho dự án của bạn tại đây
            }
        }
        stage('Test') {
            steps {
                // Thực hiện các bước kiểm tra (test)
                echo 'Running tests...'
                // Thêm lệnh chạy test tại đây
            }
        }
        stage('Deploy') {
            steps {
                // Thực hiện các bước triển khai (deploy)
                echo 'Deploying the application...'
                // Thêm lệnh triển khai tại đây
            }
        }
    }
}
