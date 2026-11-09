# Fact 0a33d342

Store id: e560a9b6-8b78-4fe6-a027-5830f95702a8

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
- posted_at: `2026-11-09T22:39:41.0281740+00:00`

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
  "id": "e560a9b6-8b78-4fe6-a027-5830f95702a8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.0281740+00:00"
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
  "subject_id": "beb0446a-c2e5-4a43-a708-1cc69624c171",
  "subject_name": "django/db/models/deletion::DatabaseOnDelete",
  "tags": [
    "entity:class"
  ],
  "text": "class DatabaseOnDelete"
}
```
