# Fact ab54e620

Store id: e694c7c9-6557-4582-b840-215d22955490

## Text

```text
class EmptyManager(Manager)
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
- posted_at: `2026-11-09T23:44:55.3217420+00:00`

## Data

```json
{
  "end_line": 213,
  "entity_kind": "class",
  "parent": "manager",
  "start_line": 207,
  "symbol": "EmptyManager"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/manager.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":207,"selector":"L207-L213","symbol":"EmptyManager"}`

## Referenced by

None.

## Subject

[django/db/models/manager::EmptyManager](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 213,
    "entity_kind": "class",
    "parent": "manager",
    "start_line": 207,
    "symbol": "EmptyManager"
  },
  "id": "e694c7c9-6557-4582-b840-215d22955490",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.3217420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 207,
        "selector": "L207-L213",
        "symbol": "EmptyManager"
      },
      "rel": "derived_from",
      "target": "django/db/models/manager.py"
    }
  ],
  "status": "live",
  "subject_id": "df1eb2b8-86f5-41e6-a6b6-2965ced2e6ee",
  "subject_name": "django/db/models/manager::EmptyManager",
  "tags": [
    "entity:class"
  ],
  "text": "class EmptyManager(Manager)"
}
```
