# Fact fae4042a

Store id: ccb00195-7802-4549-b865-6c2b69b5ce3a

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
- posted_at: `2026-11-09T22:39:45.9319220+00:00`

## Data

```json
{
  "end_line": 101,
  "entity_kind": "method",
  "parent": "Coalesce",
  "start_line": 88,
  "symbol": "Coalesce.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/comparison.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":88,"selector":"L88-L101","symbol":"Coalesce.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/comparison::Coalesce.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 101,
    "entity_kind": "method",
    "parent": "Coalesce",
    "start_line": 88,
    "symbol": "Coalesce.as_oracle"
  },
  "id": "ccb00195-7802-4549-b865-6c2b69b5ce3a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.9319220+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 88,
        "selector": "L88-L101",
        "symbol": "Coalesce.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/comparison.py"
    }
  ],
  "status": "live",
  "subject_id": "39386cab-caf2-4bea-907d-ba8777aa4f2d",
  "subject_name": "django/db/models/functions/comparison::Coalesce.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
