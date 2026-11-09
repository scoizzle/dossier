# Fact 1d1abc8b

Store id: e2823ed4-6551-4459-aaf0-580d69d0f64f

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
- posted_at: `2026-11-09T23:44:56.1976480+00:00`

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
  "id": "e2823ed4-6551-4459-aaf0-580d69d0f64f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.1976480+00:00"
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
  "subject_id": "52813487-c68d-4adc-a598-0bec79ab2fc6",
  "subject_name": "django/db/models/query::InstanceCheckMeta",
  "tags": [
    "entity:class"
  ],
  "text": "class InstanceCheckMeta(type)"
}
```
