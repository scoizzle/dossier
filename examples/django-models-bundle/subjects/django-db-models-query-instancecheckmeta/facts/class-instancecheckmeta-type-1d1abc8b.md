# Fact 1d1abc8b

Store id: b34da02f-09e6-4f23-89bf-cc083ec67694

## Text

```text
class InstanceCheckMeta(type)
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
- posted_at: `2026-11-09T22:39:49.7544260+00:00`

## Data

```json
{
  "end_line": 2397,
  "entity_kind": "class",
  "parent": "query",
  "start_line": 2395,
  "symbol": "InstanceCheckMeta"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2395,"selector":"L2395-L2397","symbol":"InstanceCheckMeta"}`

## Referenced by

None.

## Subject

[django/db/models/query::InstanceCheckMeta](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2397,
    "entity_kind": "class",
    "parent": "query",
    "start_line": 2395,
    "symbol": "InstanceCheckMeta"
  },
  "id": "b34da02f-09e6-4f23-89bf-cc083ec67694",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.7544260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2395,
        "selector": "L2395-L2397",
        "symbol": "InstanceCheckMeta"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a1a79be1-a9e2-44fe-b1a8-ebc45c1bca8c",
  "subject_name": "django/db/models/query::InstanceCheckMeta",
  "tags": [
    "entity:class"
  ],
  "text": "class InstanceCheckMeta(type)"
}
```
