# Fact a91c9bf6

Store id: 44a9c90f-58a7-426e-9ae3-254ec7950843

## Text

```text
def as_sql(self, compiler, connection)
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
- posted_at: `2026-11-09T23:44:49.5352020+00:00`

## Data

```json
{
  "end_line": 1260,
  "entity_kind": "method",
  "parent": "JSONNull",
  "start_line": 1256,
  "symbol": "JSONNull.as_sql"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1256,"selector":"L1256-L1260","symbol":"JSONNull.as_sql"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::JSONNull.as_sql](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1260,
    "entity_kind": "method",
    "parent": "JSONNull",
    "start_line": 1256,
    "symbol": "JSONNull.as_sql"
  },
  "id": "44a9c90f-58a7-426e-9ae3-254ec7950843",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.5352020+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1256,
        "selector": "L1256-L1260",
        "symbol": "JSONNull.as_sql"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "fc4c1772-a98b-4f3d-a214-123e88b2a980",
  "subject_name": "django/db/models/expressions::JSONNull.as_sql",
  "tags": [
    "entity:method"
  ],
  "text": "def as_sql(self, compiler, connection)"
}
```
