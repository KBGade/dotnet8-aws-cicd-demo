variable "aws_region" {
  type    = string
  default = "ap-south-1"
}

variable "app_name" {
  type    = string
  default = "demo-api"
}

variable "container_port" {
  type    = number
  default = 8080
}

variable "image_tag" {
  description = "Tag for Docker image in ECR"
  type        = string
  default     = "latest"
}

variable "environment" {
  description = "Environment name used in tags (dev/stage/prod)"
  type        = string
  default     = "dev"
}

variable "owner" {
  description = "Owner tag for resources (e.g., your name or team)"
  type        = string
  default     = "Kiran-"
}
