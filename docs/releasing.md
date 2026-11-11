# Releasing

Maintainer notes. Users: see [install](install.md).

## Cutting a release

To cut a release, tag a commit that is on `main` and push the tag:

```sh
git tag v1.2.3
git push origin v1.2.3
```

The tag must look like `vMAJOR.MINOR.PATCH` with an optional prerelease suffix (`v1.2.3-rc.1`; a suffix marks the GitHub release as a prerelease). The release workflow builds Native AOT binaries, smoke-tests each one, and publishes a GitHub release with these assets:

- `dossier-<version>-linux-x64.tar.gz`
- `dossier-<version>-linux-arm64.tar.gz`
- `dossier-<version>-osx-arm64.tar.gz`
- `dossier-<version>-win-x64.zip`
- `SHA256SUMS`
