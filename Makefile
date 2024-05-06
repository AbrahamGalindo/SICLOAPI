FW_NAME=siclo-automation-framework
NAME=siclo-api-automation
TAG=$$(git log --pretty=format:"%h" -1)
CURRENT_DATE=$(shell date +%Y%m%d%H)
IMG=${NAME}:${CURRENT_DATE}-${TAG}
FW_IMG=${FW_NAME}:${CURRENT_DATE}-${TAG}
LATEST=${NAME}:latest
FW_LATEST=${FW_NAME}:latest

build:
	docker build --no-cache -t ${IMG}  .

tag:
	docker tag ${IMG} 352631681906.dkr.ecr.us-east-1.amazonaws.com/${IMG}
	docker tag ${IMG} 352631681906.dkr.ecr.us-east-1.amazonaws.com/${LATEST}

push:
	docker push 352631681906.dkr.ecr.us-east-1.amazonaws.com/${IMG}
	docker push 352631681906.dkr.ecr.us-east-1.amazonaws.com/${LATEST}

deploy:
	make build
	make tag
	make push

build-fw:
	docker build -f Framework.Dockerfile --no-cache -t ${FW_IMG} .

tag-fw:
	docker tag ${FW_IMG} 352631681906.dkr.ecr.us-east-1.amazonaws.com/${FW_IMG}
	docker tag ${FW_IMG} 352631681906.dkr.ecr.us-east-1.amazonaws.com/${FW_LATEST}

push-fw:
	docker push 352631681906.dkr.ecr.us-east-1.amazonaws.com/${FW_IMG}
	docker push 352631681906.dkr.ecr.us-east-1.amazonaws.com/${FW_LATEST}

deploy-fw:
	make build-fw
	make tag-fw
	make push-fw
