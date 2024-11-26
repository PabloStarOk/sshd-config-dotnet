# SSH Daemon Configuration

- [ ] Add `SshdConfig`, a class responsible for storing and reflecting the same information of `sshd_config`.
- [ ] Add `SshdConfigReader`, a class responsible for reading sshd configuration.
- [ ] Add `SshdConfigWriter`, a class responsible for writing changes to `sshd_config` file.
- [ ] Add `SshdConfigService` a class responsible for orchestrating reading, writing and storing.
- [ ] Add `SshdConfigReloader`, a class responsible for updating changes and reloading `ssh daemon`.
- [ ] Add `SshdConfigValidator`, a class responsible for validating a `sshd_config` file. 
- [ ] Add `SshdConfigRecovery`, a class responsible for making backups and inject automated scripts in the remote server to load the backups and reload `ssh daemon` in case of bad configuration.
- [ ] Update `SshdConfigService` to include reloading, validating and recovery.

# Other Tasks

- [ ] Add support for `ssh.socket`.
- [ ] Add support for `ssh.service`.
