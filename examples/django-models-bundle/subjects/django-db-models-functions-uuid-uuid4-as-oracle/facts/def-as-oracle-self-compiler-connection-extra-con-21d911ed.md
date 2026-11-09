# Fact 21d911ed

Store id: c15f4bb4-59c9-4500-adfa-cbaf862ed2c4

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
- posted_at: `2026-11-09T23:32:02.4915710+00:00`

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
  "id": "c15f4bb4-59c9-4500-adfa-cbaf862ed2c4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.4915710+00:00"
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
  "subject_id": "237d44ee-3640-474c-a505-86f365003e5e",
  "subject_name": "django/db/models/functions/uuid::UUID4.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
