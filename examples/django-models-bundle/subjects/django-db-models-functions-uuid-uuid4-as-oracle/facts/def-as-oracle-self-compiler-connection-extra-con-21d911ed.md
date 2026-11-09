# Fact 21d911ed

Store id: 5bd1c636-55dc-4b85-b98e-78ce575ff6be

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T22:39:47.3737690+00:00`

## Data

```json
{
  "end_line": 44,
  "entity_kind": "method",
  "parent": "UUID4",
  "start_line": 30,
  "symbol": "UUID4.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/uuid.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":30,"selector":"L30-L44","symbol":"UUID4.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/uuid::UUID4.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 44,
    "entity_kind": "method",
    "parent": "UUID4",
    "start_line": 30,
    "symbol": "UUID4.as_oracle"
  },
  "id": "5bd1c636-55dc-4b85-b98e-78ce575ff6be",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.3737690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 30,
        "selector": "L30-L44",
        "symbol": "UUID4.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/uuid.py"
    }
  ],
  "status": "live",
  "subject_id": "8f2e5d95-f76a-4de8-89f0-135d4566fb3e",
  "subject_name": "django/db/models/functions/uuid::UUID4.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
