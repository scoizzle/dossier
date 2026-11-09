# Fact 664ab9e5

Store id: 6c4f4c70-0352-46e2-aac7-06ed88bcc6cf

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
- posted_at: `2026-11-09T22:39:49.8362560+00:00`

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
  "id": "6c4f4c70-0352-46e2-aac7-06ed88bcc6cf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.8362560+00:00"
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
  "subject_id": "e0ac7d28-49f6-491d-8f7b-de77d0ade658",
  "subject_name": "django/db/models/query::Prefetch",
  "tags": [
    "entity:class"
  ],
  "text": "class Prefetch"
}
```
