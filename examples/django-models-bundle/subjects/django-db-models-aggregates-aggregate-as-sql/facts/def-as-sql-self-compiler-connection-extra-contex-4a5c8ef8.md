# Fact 4a5c8ef8

Store id: 7b6686cc-cc5e-48c3-aecd-f88f73deb72a

## Text

```text
def as_sql(self, compiler, connection, **extra_context)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.3971570+00:00`

## Data

```json
{
  "end_line": 213,
  "entity_kind": "method",
  "parent": "Aggregate",
  "start_line": 174,
  "symbol": "Aggregate.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":174,"selector":"L174-L213","symbol":"Aggregate.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 213,
    "entity_kind": "method",
    "parent": "Aggregate",
    "start_line": 174,
    "symbol": "Aggregate.as_sql"
  },
  "id": "7b6686cc-cc5e-48c3-aecd-f88f73deb72a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.3971570+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 174,
        "selector": "L174-L213",
        "symbol": "Aggregate.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "489a7a04-c94b-49e9-bef1-c226493b3bd2",
  "subject_name": "django/db/models/aggregates::Aggregate.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection, **extra_context)"
}
```
