# Fact 1d1abc8b

Store id: c35fbf76-243b-4592-a4ad-8ac1d79bd2c9

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
- posted_at: `2026-11-09T23:32:04.6904860+00:00`

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
  "id": "c35fbf76-243b-4592-a4ad-8ac1d79bd2c9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.6904860+00:00"
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
  "subject_id": "e1703eaa-fb5e-41c8-a4d2-0dd676e1f4ee",
  "subject_name": "django/db/models/query::InstanceCheckMeta",
  "tags": [
    "entity:class"
  ],
  "text": "class InstanceCheckMeta(type)"
}
```
