# Fact b10e78c8

Store id: 7b3fc288-38b9-4c37-a3c4-a40887568f3f

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
- posted_at: `2026-11-09T22:39:47.9596380+00:00`

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
  "id": "7b3fc288-38b9-4c37-a3c4-a40887568f3f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.9596380+00:00"
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
  "subject_id": "5503c1ab-7f58-411a-82cb-845fda340b6d",
  "subject_name": "django/db/models/lookups::Lookup",
  "tags": [
    "entity:class"
  ],
  "text": "class Lookup(Expression)"
}
```
