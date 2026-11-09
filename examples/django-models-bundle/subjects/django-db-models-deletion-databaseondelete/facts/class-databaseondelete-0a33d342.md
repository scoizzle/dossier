# Fact 0a33d342

Store id: b173b94d-37c5-4e2b-90d2-28d9dc746a2d

## Text

```text
class DatabaseOnDelete
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.0844270+00:00`

## Data

```json
{
  "end_line": 96,
  "entity_kind": "class",
  "parent": "deletion",
  "start_line": 84,
  "symbol": "DatabaseOnDelete"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/deletion.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":84,"selector":"L84-L96","symbol":"DatabaseOnDelete"}`

## Referenced by

None.

## Subject

[django/db/models/deletion::DatabaseOnDelete](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 96,
    "entity_kind": "class",
    "parent": "deletion",
    "start_line": 84,
    "symbol": "DatabaseOnDelete"
  },
  "id": "b173b94d-37c5-4e2b-90d2-28d9dc746a2d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.0844270+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 84,
        "selector": "L84-L96",
        "symbol": "DatabaseOnDelete"
      },
      "rel": "derived_from",
      "target": "django/db/models/deletion.py"
    }
  ],
  "status": "live",
  "subject_id": "4b1d0377-ae61-4a39-87e7-9897bb1faa63",
  "subject_name": "django/db/models/deletion::DatabaseOnDelete",
  "tags": [
    "entity:class"
  ],
  "text": "class DatabaseOnDelete"
}
```
