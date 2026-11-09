# Fact ab54e620

Store id: c5678ddc-d991-4b13-9407-51435c731a7f

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
- posted_at: `2026-11-09T22:39:48.5491870+00:00`

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
  "id": "c5678ddc-d991-4b13-9407-51435c731a7f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.5491870+00:00"
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
  "subject_id": "7cbbc2fa-e7b1-4e01-9800-9001b2de69aa",
  "subject_name": "django/db/models/manager::EmptyManager",
  "tags": [
    "entity:class"
  ],
  "text": "class EmptyManager(Manager)"
}
```
