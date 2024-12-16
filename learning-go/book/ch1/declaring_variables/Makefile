.DEFAULT_PATH := build

PHONY: fmt vet build

fmt:
	go gmt ./...

vet: fmt
	go vet ./...

build: vet
	go build

clean:
	go clean