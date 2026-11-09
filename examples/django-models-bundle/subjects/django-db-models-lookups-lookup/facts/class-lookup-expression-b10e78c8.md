# Fact b10e78c8

Store id: 14e0f1b0-6f1d-4b05-ae6f-86761c49917f

## Text

```text
class Lookup(Expression)
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
- posted_at: `2026-11-09T23:44:54.8352640+00:00`

## Data

```json
{
  "end_line": 208,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 29,
  "symbol": "Lookup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":29,"selector":"L29-L208","symbol":"Lookup"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 208,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 29,
    "symbol": "Lookup"
  },
  "id": "14e0f1b0-6f1d-4b05-ae6f-86761c49917f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.8352640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 29,
        "selector": "L29-L208",
        "symbol": "Lookup"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "56ca0be3-11b7-46f6-89d7-ca7886943dd1",
  "subject_name": "django/db/models/lookups::Lookup",
  "tags": [
    "entity:class"
  ],
  "text": "class Lookup(Expression)"
}
```
