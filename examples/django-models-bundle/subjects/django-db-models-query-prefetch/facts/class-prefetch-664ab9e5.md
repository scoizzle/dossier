# Fact 664ab9e5

Store id: 10ab8210-813c-4dd4-aa46-ed1091ad994d

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
- posted_at: `2026-11-09T23:44:56.2760130+00:00`

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
  "id": "10ab8210-813c-4dd4-aa46-ed1091ad994d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2760130+00:00"
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
  "subject_id": "fefa1df9-322d-4ccb-a114-dbfc091c535c",
  "subject_name": "django/db/models/query::Prefetch",
  "tags": [
    "entity:class"
  ],
  "text": "class Prefetch"
}
```
