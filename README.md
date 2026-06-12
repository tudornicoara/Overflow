# Overflow

## Commands

### Deploy to production

```
aspire deploy -o infra
```

Generates the production `docker-compose.yaml` and supporting files into the `infra/` directory from the Aspire AppHost configuration. Run this whenever the AppHost changes (new services, environment variables, ports, etc.) to keep the infra output in sync.

---

### Tear down the production stack

```
aspire do docker-compose-down-production -o infra
```

Stops and removes all containers defined in `infra/docker-compose.yaml`. Volumes are preserved, so persistent data (Postgres, Keycloak, Typesense, RabbitMQ) survives the shutdown. Re-run `docker compose -f infra/docker-compose.yaml up -d` to bring everything back up.
