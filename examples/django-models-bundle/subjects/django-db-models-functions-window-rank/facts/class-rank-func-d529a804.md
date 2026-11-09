# Fact d529a804

Store id: 9a4e3794-d483-46b1-ae1d-73943fc96e83

## Text

```text
class Rank(Func)
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
- posted_at: `2026-11-09T22:39:47.6041490+00:00`

## Data

```json
{
  "end_line": 114,
  "entity_kind": "class",
  "parent": "window",
  "start_line": 111,
  "symbol": "Rank"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":111,"selector":"L111-L114","symbol":"Rank"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::Rank](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 114,
    "entity_kind": "class",
    "parent": "window",
    "start_line": 111,
    "symbol": "Rank"
  },
  "id": "9a4e3794-d483-46b1-ae1d-73943fc96e83",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.6041490+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 111,
        "selector": "L111-L114",
        "symbol": "Rank"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "5064388b-97bf-4809-9d78-866df62bb26d",
  "subject_name": "django/db/models/functions/window::Rank",
  "tags": [
    "entity:class"
  ],
  "text": "class Rank(Func)"
}
```
