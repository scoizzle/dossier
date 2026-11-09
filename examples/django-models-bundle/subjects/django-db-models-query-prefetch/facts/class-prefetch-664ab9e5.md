# Fact 664ab9e5

Store id: 44db889f-bf1d-417e-9c58-b5b2d6ff5dd1

## Text

```text
class Prefetch
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
- posted_at: `2026-11-09T23:32:04.7818110+00:00`

## Data

```json
{
  "end_line": 2631,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 2570,
  "symbol": "Prefetch"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2570,"selector":"L2570-L2631","symbol":"Prefetch"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2631,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 2570,
    "symbol": "Prefetch"
  },
  "id": "44db889f-bf1d-417e-9c58-b5b2d6ff5dd1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7818110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2570,
        "selector": "L2570-L2631",
        "symbol": "Prefetch"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "09748518-8783-4c23-ac00-1d73ba872f21",
  "subject_name": "django/db/models/query::Prefetch",
  "tags": [
    "entity:class"
  ],
  "text": "class Prefetch"
}
```
